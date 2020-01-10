using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace CropPhoto
{
    public partial class Form1 : Form
    {
        /*Source image to edit*/
        public Image SourceImage { get; private set; }

        /*File path of source image*/
        public string FilePath { get; private set; } = "";

        /*File name of source image*/
        public string FileName { get; private set; } = "";

        /*Output path of cropped image*/
        public string OutputPath { get; private set; } = "";

        /*Selected Dimension*/
        public IntPaper.Dimension Dimension { get; private set; } = IntPaper.Dimension.A4;

        /*Used for fitting the ratio of image size to A3/A4 ratio*/
        public IntPaper.Direction Direction { get; private set; } = IntPaper.Direction.Portrait;

        public int enlargeFactor(float original_width, int selectedIndex)
        {
            int count = 2;
            float temp = original_width;
            float fitWidth = 0;

            switch (selectedIndex)
            {
                case (int)IntPaper.Dimension.A3:
                    fitWidth = 3508;
                    break;
                case (int)IntPaper.Dimension.A4:
                    fitWidth = 2480;
                    break;
            }

            while (temp < fitWidth)
            {
                temp *= count;
                if (temp < fitWidth)
                {
                    temp = original_width;
                    count++;
                }
            }
            return count;
        }

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            /*set data for top panel*/
            lbl_imgName.Text = "";
            lbl_imgSize.Text = "";
            lbl_cropFrameSize.Text = "";
            lbl_cropTotalNum.Text = "0";

            /*set data for left panel*/
            btn_fileSelector.Text = "選擇檔案";
            txt_scaleSize.Text = "5";
            btn_outputDir.Text = "選擇輸出位置";
            cb_cropDirection.SelectedIndex = 0;
            cb_dimension.SelectedIndex = 1;
            //default: current directory
            OutputPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            /*allow drop the image to picture preview box*/
            picture_preview.AllowDrop = true;
        }

        /*The most left panel*/
        private void btn_fileSelector_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opd = new OpenFileDialog())
            {
                opd.Filter = "Image files (*.png;*.jpeg;*.jpg;*.bmp)|*.png;*.jpeg;*.jpg;*.bmp|All files (*.*)|.";
                if (opd.ShowDialog() == DialogResult.OK)
                {
                    SourceImage = Image.FromFile(opd.FileName);
                    lbl_imgSize.Text = SourceImage.Width + "x" + SourceImage.Height;
                    btn_fileSelector.Text = FilePath = opd.FileName;
                    picture_preview.Image = SourceImage;
                    lbl_tips_dragImage.SendToBack();
                    string[] file = FilePath.Split('\\');
                    FileName = file[file.Length - 1];
                    lbl_imgName.Text = FileName;
                    updatePreview();
                }
            }
        }

        private void txt_scaleSize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_scaleSize.Text.Equals(""))
                {
                    lbl_cropTotalNum.Text = "0";
                }
                else
                {
                    int numOfPaper = Convert.ToInt32(txt_scaleSize.Text);
                    lbl_cropTotalNum.Text = (numOfPaper * numOfPaper).ToString();
                    updatePreview();
                }
            }
            catch (Exception ex)
            {
                txt_scaleSize.Text = "";
                showMsgBox("請輸入數字");
            }
        }

        private void btn_outputDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = fbd.SelectedPath;
                    if (string.IsNullOrWhiteSpace(selectedPath))
                    {
                        OutputPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    }
                    else
                    {
                        btn_outputDir.Text = OutputPath = selectedPath;
                    }
                }
            }
        }

        private void cb_cropDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Direction = (IntPaper.Direction)cb_cropDirection.SelectedIndex;
            updatePreview();
        }

        private void cb_dimension_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dimension = (IntPaper.Dimension)cb_dimension.SelectedIndex;
            updatePreview();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (FilePath.Equals("") || txt_scaleSize.Text.Equals("")) return;

            int numOfPaper = Convert.ToInt32(txt_scaleSize.Text);

            Size outputSize = IntPaper.Resize(SourceImage.Size, Dimension, Direction);

            int aWidth = (int)Math.Round((double)outputSize.Width / numOfPaper);
            int aHeight = (int)Math.Round((double)outputSize.Height / numOfPaper);
            int count = 0;

            //Accumnlation size to prevent export white image
            int accumuWidth = 0;

            for (int i = 0; i < numOfPaper; i++)
            {
                if (accumuWidth >= SourceImage.Width) continue;
                int accumuHeight = 0;
                for (int j = 0; j < numOfPaper; j++)
                {
                    if (accumuHeight >= SourceImage.Height) continue;
                    Rectangle cropRect = new Rectangle(aWidth * i, aHeight * j, aWidth, aHeight);
                    Bitmap croppedImage = Cutter.Crop(SourceImage, cropRect);

                    switch (cb_cropDirection.SelectedIndex)
                    {
                        case (int)Cutter.Orientation.landscape:
                            croppedImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            break;
                    }

                    //Enlarge sourceImage image
                    float scaleFactor = enlargeFactor(croppedImage.Width, cb_dimension.SelectedIndex);
                    int newWidth = (int)Math.Ceiling(croppedImage.Width * scaleFactor);
                    int newHeight = (int)Math.Ceiling(croppedImage.Height * scaleFactor);
                    Bitmap scaledImage = new Bitmap(croppedImage, new Size(newWidth, newHeight));
                    scaledImage.SetResolution(300, 300);
                    scaledImage.Save(OutputPath + "/" + count + "_" + FileName + ".jpg");
                    croppedImage.Dispose();
                    scaledImage.Dispose();
                    count++;
                    accumuHeight += aHeight;
                }
                accumuWidth += aWidth;
            }
            btn_fileSelector.Text = "選擇下一張";
            Console.WriteLine(Directory.Exists(OutputPath));

            Process.Start("explorer.exe", OutputPath);
            
        }

        private void picture_preview_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if(data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    string path = fileNames[0];
                    if (ImageHandler.IsValidImage(fileNames[0]))
                    {
                        SourceImage = Image.FromFile(path);
                        lbl_imgSize.Text = SourceImage.Width + "x" + SourceImage.Height;
                        btn_fileSelector.Text = FilePath = path;
                        picture_preview.Image = SourceImage;
                        lbl_tips_dragImage.SendToBack();
                        string[] file = FilePath.Split('\\');
                        FileName = file[file.Length - 1];
                        lbl_imgName.Text = FileName;
                        updatePreview();
                    }
                }
            }
        }

        private void picture_preview_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btn_rotate_left_Click(object sender, EventArgs e)
        {
            if (SourceImage == null) return;
            SourceImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            lbl_imgSize.Text = SourceImage.Width + "x" + SourceImage.Height;
            picture_preview.Image = SourceImage;
            updatePreview();
        }

        private void btn_rotate_right_Click(object sender, EventArgs e)
        {
            if (SourceImage == null) return;
            SourceImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            lbl_imgSize.Text = SourceImage.Width + "x" + SourceImage.Height;
            picture_preview.Image = SourceImage;
            updatePreview();
        }

        private void btn_flip_topBottom_Click(object sender, EventArgs e)
        {
            if (SourceImage == null) return;
            SourceImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
            lbl_imgSize.Text = SourceImage.Width + "x" + SourceImage.Height;
            picture_preview.Image = SourceImage;
            updatePreview();
        }

        private void btn_flip_leftRight_Click(object sender, EventArgs e)
        {
            if (SourceImage == null) return;
            SourceImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            lbl_imgSize.Text = SourceImage.Width + "x" + SourceImage.Height;
            picture_preview.Image = SourceImage;
            updatePreview();
        }

        public void showMsgBox(string message)
        {
            MessageBox msgBox = new MessageBox();
            msgBox.StartPosition = FormStartPosition.CenterScreen;
            msgBox.lbl_msg.Text = message;
            DialogResult result = msgBox.ShowDialog();
            if (result == DialogResult.OK)
            {
                msgBox.Visible = false;
            }
            msgBox.Dispose();
        }

        private void pb_cropFrame_color_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                pb_cropFrame_color.BackColor = cd.Color;
                updatePreview();
            }
        }

        private void updatePreview()
        {
            if (FilePath.Equals("") || txt_scaleSize.Text.Equals("")) return;

            int numOfPaper = Convert.ToInt32(txt_scaleSize.Text);

            Size outputSize = IntPaper.Resize(SourceImage.Size, Dimension, Direction);

            int aWidth = (int)Math.Round((double)outputSize.Width / numOfPaper);
            int aHeight = (int)Math.Round((double)outputSize.Height / numOfPaper);

            lbl_cropFrameSize.Text = aWidth + "x" + aHeight;

            Image img = new Bitmap(SourceImage);

            using (var graphics = Graphics.FromImage(img))
            {
                Pen pen = new Pen(pb_cropFrame_color.BackColor, Math.Min(img.Width, img.Height) * 0.01f);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                /*for (int i = 1; i < numOfPaper; i++)
                {
                    for (int j = 1; j < numOfPaper; j++)
                    {
                        //Rectangle cropRect = new Rectangle(aWidth * i, aHeight * j, aWidth, aHeight);
                        //graphics.DrawRectangle(pen, cropRect);
                    }
                }*/

                for (int i = 1; i < numOfPaper; i++)
                {
                    graphics.DrawLine(pen, aWidth * i, 0, aWidth * i, aHeight * numOfPaper);
                    graphics.DrawLine(pen, 0, aHeight * i, aWidth * numOfPaper, aHeight * i);
                }

                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                graphics.DrawLine(pen, 0, 0, img.Width, 0);
                graphics.DrawLine(pen, 0, 0, 0, img.Height);
                graphics.DrawLine(pen, img.Width, img.Height, 0, img.Height);
                graphics.DrawLine(pen, img.Width, img.Height, img.Width, 0);
            }
            picture_preview.Image = img;
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {

        }
    }
}