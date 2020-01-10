namespace CropPhoto
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.submit = new System.Windows.Forms.Button();
            this.panel_scaleSize = new System.Windows.Forms.Panel();
            this.lbl_title_scaleSize = new System.Windows.Forms.Label();
            this.txt_scaleSize = new System.Windows.Forms.TextBox();
            this.panel_outputDir = new System.Windows.Forms.Panel();
            this.lbl_title_outputDir = new System.Windows.Forms.Label();
            this.btn_outputDir = new System.Windows.Forms.Button();
            this.panel_imgSource = new System.Windows.Forms.Panel();
            this.lbl_title_imgSource = new System.Windows.Forms.Label();
            this.btn_fileSelector = new System.Windows.Forms.Button();
            this.panel_dimension = new System.Windows.Forms.Panel();
            this.cb_dimension = new System.Windows.Forms.ComboBox();
            this.lbl_title_dimension = new System.Windows.Forms.Label();
            this.picture_preview = new System.Windows.Forms.PictureBox();
            this.panel_dataInput = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_cropDirection = new System.Windows.Forms.Panel();
            this.cb_cropDirection = new System.Windows.Forms.ComboBox();
            this.lbl_title_cropDirection = new System.Windows.Forms.Label();
            this.panel_button = new System.Windows.Forms.Panel();
            this.panel_fill = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pb_cropFrame_color = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_rotate_left = new System.Windows.Forms.Button();
            this.btn_flip_leftRight = new System.Windows.Forms.Button();
            this.btn_rotate_right = new System.Windows.Forms.Button();
            this.btn_flip_topBottom = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_tips_dragImage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_cropFrameSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_title_imgName = new System.Windows.Forms.Label();
            this.lbl_imgName = new System.Windows.Forms.Label();
            this.lbl_title_cropTotalNum = new System.Windows.Forms.Label();
            this.lbl_cropTotalNum = new System.Windows.Forms.Label();
            this.lbl_title_imgSize = new System.Windows.Forms.Label();
            this.lbl_imgSize = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel_scaleSize.SuspendLayout();
            this.panel_outputDir.SuspendLayout();
            this.panel_imgSource.SuspendLayout();
            this.panel_dimension.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_preview)).BeginInit();
            this.panel_dataInput.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_cropDirection.SuspendLayout();
            this.panel_button.SuspendLayout();
            this.panel_fill.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cropFrame_color)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(7, 5);
            this.submit.Margin = new System.Windows.Forms.Padding(4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(204, 35);
            this.submit.TabIndex = 6;
            this.submit.Text = "確認";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // panel_scaleSize
            // 
            this.panel_scaleSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.panel_scaleSize.Controls.Add(this.lbl_title_scaleSize);
            this.panel_scaleSize.Controls.Add(this.txt_scaleSize);
            this.panel_scaleSize.Location = new System.Drawing.Point(5, 107);
            this.panel_scaleSize.Name = "panel_scaleSize";
            this.panel_scaleSize.Size = new System.Drawing.Size(220, 45);
            this.panel_scaleSize.TabIndex = 20;
            // 
            // lbl_title_scaleSize
            // 
            this.lbl_title_scaleSize.AutoSize = true;
            this.lbl_title_scaleSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.lbl_title_scaleSize.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_title_scaleSize.Location = new System.Drawing.Point(19, 13);
            this.lbl_title_scaleSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title_scaleSize.Name = "lbl_title_scaleSize";
            this.lbl_title_scaleSize.Size = new System.Drawing.Size(52, 15);
            this.lbl_title_scaleSize.TabIndex = 5;
            this.lbl_title_scaleSize.Text = "長 x 闊";
            // 
            // txt_scaleSize
            // 
            this.txt_scaleSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.txt_scaleSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_scaleSize.ForeColor = System.Drawing.Color.White;
            this.txt_scaleSize.Location = new System.Drawing.Point(79, 10);
            this.txt_scaleSize.Margin = new System.Windows.Forms.Padding(4);
            this.txt_scaleSize.Name = "txt_scaleSize";
            this.txt_scaleSize.Size = new System.Drawing.Size(132, 25);
            this.txt_scaleSize.TabIndex = 1;
            this.txt_scaleSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_scaleSize.TextChanged += new System.EventHandler(this.txt_scaleSize_TextChanged);
            // 
            // panel_outputDir
            // 
            this.panel_outputDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.panel_outputDir.Controls.Add(this.lbl_title_outputDir);
            this.panel_outputDir.Controls.Add(this.btn_outputDir);
            this.panel_outputDir.Location = new System.Drawing.Point(5, 56);
            this.panel_outputDir.Name = "panel_outputDir";
            this.panel_outputDir.Size = new System.Drawing.Size(220, 45);
            this.panel_outputDir.TabIndex = 22;
            // 
            // lbl_title_outputDir
            // 
            this.lbl_title_outputDir.AutoSize = true;
            this.lbl_title_outputDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.lbl_title_outputDir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_title_outputDir.Location = new System.Drawing.Point(4, 15);
            this.lbl_title_outputDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title_outputDir.Name = "lbl_title_outputDir";
            this.lbl_title_outputDir.Size = new System.Drawing.Size(67, 15);
            this.lbl_title_outputDir.TabIndex = 7;
            this.lbl_title_outputDir.Text = "輸出位置";
            // 
            // btn_outputDir
            // 
            this.btn_outputDir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_outputDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_outputDir.ForeColor = System.Drawing.Color.White;
            this.btn_outputDir.Location = new System.Drawing.Point(79, 7);
            this.btn_outputDir.Name = "btn_outputDir";
            this.btn_outputDir.Size = new System.Drawing.Size(132, 30);
            this.btn_outputDir.TabIndex = 18;
            this.btn_outputDir.UseVisualStyleBackColor = true;
            this.btn_outputDir.Click += new System.EventHandler(this.btn_outputDir_Click);
            // 
            // panel_imgSource
            // 
            this.panel_imgSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.panel_imgSource.Controls.Add(this.lbl_title_imgSource);
            this.panel_imgSource.Controls.Add(this.btn_fileSelector);
            this.panel_imgSource.Location = new System.Drawing.Point(5, 5);
            this.panel_imgSource.Name = "panel_imgSource";
            this.panel_imgSource.Size = new System.Drawing.Size(220, 45);
            this.panel_imgSource.TabIndex = 19;
            // 
            // lbl_title_imgSource
            // 
            this.lbl_title_imgSource.AutoSize = true;
            this.lbl_title_imgSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.lbl_title_imgSource.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title_imgSource.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_title_imgSource.Location = new System.Drawing.Point(4, 15);
            this.lbl_title_imgSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title_imgSource.Name = "lbl_title_imgSource";
            this.lbl_title_imgSource.Size = new System.Drawing.Size(67, 15);
            this.lbl_title_imgSource.TabIndex = 3;
            this.lbl_title_imgSource.Text = "圖片來源";
            // 
            // btn_fileSelector
            // 
            this.btn_fileSelector.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_fileSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fileSelector.ForeColor = System.Drawing.Color.White;
            this.btn_fileSelector.Location = new System.Drawing.Point(79, 7);
            this.btn_fileSelector.Margin = new System.Windows.Forms.Padding(4);
            this.btn_fileSelector.Name = "btn_fileSelector";
            this.btn_fileSelector.Size = new System.Drawing.Size(132, 30);
            this.btn_fileSelector.TabIndex = 17;
            this.btn_fileSelector.UseVisualStyleBackColor = true;
            this.btn_fileSelector.Click += new System.EventHandler(this.btn_fileSelector_Click);
            // 
            // panel_dimension
            // 
            this.panel_dimension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.panel_dimension.Controls.Add(this.cb_dimension);
            this.panel_dimension.Controls.Add(this.lbl_title_dimension);
            this.panel_dimension.Location = new System.Drawing.Point(5, 209);
            this.panel_dimension.Name = "panel_dimension";
            this.panel_dimension.Size = new System.Drawing.Size(220, 45);
            this.panel_dimension.TabIndex = 23;
            // 
            // cb_dimension
            // 
            this.cb_dimension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.cb_dimension.Cursor = System.Windows.Forms.Cursors.Default;
            this.cb_dimension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dimension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_dimension.ForeColor = System.Drawing.Color.White;
            this.cb_dimension.FormattingEnabled = true;
            this.cb_dimension.IntegralHeight = false;
            this.cb_dimension.ItemHeight = 15;
            this.cb_dimension.Items.AddRange(new object[] {
            "A3",
            "A4"});
            this.cb_dimension.Location = new System.Drawing.Point(79, 10);
            this.cb_dimension.Margin = new System.Windows.Forms.Padding(4);
            this.cb_dimension.Name = "cb_dimension";
            this.cb_dimension.Size = new System.Drawing.Size(132, 23);
            this.cb_dimension.TabIndex = 14;
            this.cb_dimension.SelectedIndexChanged += new System.EventHandler(this.cb_dimension_SelectedIndexChanged);
            // 
            // lbl_title_dimension
            // 
            this.lbl_title_dimension.AutoSize = true;
            this.lbl_title_dimension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.lbl_title_dimension.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_title_dimension.Location = new System.Drawing.Point(34, 13);
            this.lbl_title_dimension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title_dimension.Name = "lbl_title_dimension";
            this.lbl_title_dimension.Size = new System.Drawing.Size(37, 15);
            this.lbl_title_dimension.TabIndex = 13;
            this.lbl_title_dimension.Text = "尺寸";
            // 
            // picture_preview
            // 
            this.picture_preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.picture_preview.Location = new System.Drawing.Point(15, 15);
            this.picture_preview.Name = "picture_preview";
            this.picture_preview.Size = new System.Drawing.Size(790, 479);
            this.picture_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_preview.TabIndex = 0;
            this.picture_preview.TabStop = false;
            this.picture_preview.DragDrop += new System.Windows.Forms.DragEventHandler(this.picture_preview_DragDrop);
            this.picture_preview.DragEnter += new System.Windows.Forms.DragEventHandler(this.picture_preview_DragEnter);
            // 
            // panel_dataInput
            // 
            this.panel_dataInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.panel_dataInput.Controls.Add(this.panel6);
            this.panel_dataInput.Controls.Add(this.panel4);
            this.panel_dataInput.Controls.Add(this.panel2);
            this.panel_dataInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_dataInput.Location = new System.Drawing.Point(0, 41);
            this.panel_dataInput.Name = "panel_dataInput";
            this.panel_dataInput.Size = new System.Drawing.Size(260, 632);
            this.panel_dataInput.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(15, 15);
            this.panel6.Margin = new System.Windows.Forms.Padding(15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(230, 78);
            this.panel6.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 78);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.panel4.Location = new System.Drawing.Point(260, 129);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(987, 30);
            this.panel4.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel_cropDirection);
            this.panel2.Controls.Add(this.panel_button);
            this.panel2.Controls.Add(this.panel_imgSource);
            this.panel2.Controls.Add(this.panel_outputDir);
            this.panel2.Controls.Add(this.panel_scaleSize);
            this.panel2.Controls.Add(this.panel_dimension);
            this.panel2.Location = new System.Drawing.Point(15, 108);
            this.panel2.Margin = new System.Windows.Forms.Padding(15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 509);
            this.panel2.TabIndex = 25;
            // 
            // panel_cropDirection
            // 
            this.panel_cropDirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.panel_cropDirection.Controls.Add(this.cb_cropDirection);
            this.panel_cropDirection.Controls.Add(this.lbl_title_cropDirection);
            this.panel_cropDirection.Location = new System.Drawing.Point(5, 158);
            this.panel_cropDirection.Name = "panel_cropDirection";
            this.panel_cropDirection.Size = new System.Drawing.Size(220, 45);
            this.panel_cropDirection.TabIndex = 24;
            // 
            // cb_cropDirection
            // 
            this.cb_cropDirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.cb_cropDirection.Cursor = System.Windows.Forms.Cursors.Default;
            this.cb_cropDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cropDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_cropDirection.ForeColor = System.Drawing.Color.White;
            this.cb_cropDirection.FormattingEnabled = true;
            this.cb_cropDirection.IntegralHeight = false;
            this.cb_cropDirection.ItemHeight = 15;
            this.cb_cropDirection.Items.AddRange(new object[] {
            "直向",
            "橫向"});
            this.cb_cropDirection.Location = new System.Drawing.Point(79, 10);
            this.cb_cropDirection.Margin = new System.Windows.Forms.Padding(4);
            this.cb_cropDirection.Name = "cb_cropDirection";
            this.cb_cropDirection.Size = new System.Drawing.Size(132, 23);
            this.cb_cropDirection.TabIndex = 14;
            this.cb_cropDirection.SelectedIndexChanged += new System.EventHandler(this.cb_cropDirection_SelectedIndexChanged);
            // 
            // lbl_title_cropDirection
            // 
            this.lbl_title_cropDirection.AutoSize = true;
            this.lbl_title_cropDirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.lbl_title_cropDirection.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_title_cropDirection.Location = new System.Drawing.Point(4, 13);
            this.lbl_title_cropDirection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title_cropDirection.Name = "lbl_title_cropDirection";
            this.lbl_title_cropDirection.Size = new System.Drawing.Size(67, 15);
            this.lbl_title_cropDirection.TabIndex = 13;
            this.lbl_title_cropDirection.Text = "剪截方向";
            // 
            // panel_button
            // 
            this.panel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.panel_button.Controls.Add(this.submit);
            this.panel_button.Location = new System.Drawing.Point(5, 260);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(220, 45);
            this.panel_button.TabIndex = 24;
            // 
            // panel_fill
            // 
            this.panel_fill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.panel_fill.Controls.Add(this.panel8);
            this.panel_fill.Controls.Add(this.panel3);
            this.panel_fill.Controls.Add(this.panel1);
            this.panel_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fill.Location = new System.Drawing.Point(260, 41);
            this.panel_fill.Name = "panel_fill";
            this.panel_fill.Size = new System.Drawing.Size(1002, 632);
            this.panel_fill.TabIndex = 24;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.pb_cropFrame_color);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.btn_rotate_left);
            this.panel8.Controls.Add(this.btn_flip_leftRight);
            this.panel8.Controls.Add(this.btn_rotate_right);
            this.panel8.Controls.Add(this.btn_flip_topBottom);
            this.panel8.Location = new System.Drawing.Point(838, 108);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(149, 509);
            this.panel8.TabIndex = 6;
            // 
            // pb_cropFrame_color
            // 
            this.pb_cropFrame_color.BackColor = System.Drawing.Color.White;
            this.pb_cropFrame_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_cropFrame_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_cropFrame_color.Location = new System.Drawing.Point(84, 12);
            this.pb_cropFrame_color.Name = "pb_cropFrame_color";
            this.pb_cropFrame_color.Size = new System.Drawing.Size(49, 30);
            this.pb_cropFrame_color.TabIndex = 9;
            this.pb_cropFrame_color.TabStop = false;
            this.pb_cropFrame_color.Click += new System.EventHandler(this.pb_cropFrame_color_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.label2.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "框架顏色";
            // 
            // btn_rotate_left
            // 
            this.btn_rotate_left.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_rotate_left.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_rotate_left.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.btn_rotate_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rotate_left.ForeColor = System.Drawing.Color.White;
            this.btn_rotate_left.Location = new System.Drawing.Point(16, 56);
            this.btn_rotate_left.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btn_rotate_left.Name = "btn_rotate_left";
            this.btn_rotate_left.Size = new System.Drawing.Size(118, 30);
            this.btn_rotate_left.TabIndex = 1;
            this.btn_rotate_left.Text = "向左旋轉90度";
            this.btn_rotate_left.UseVisualStyleBackColor = true;
            this.btn_rotate_left.Click += new System.EventHandler(this.btn_rotate_left_Click);
            // 
            // btn_flip_leftRight
            // 
            this.btn_flip_leftRight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_flip_leftRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_flip_leftRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.btn_flip_leftRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_flip_leftRight.ForeColor = System.Drawing.Color.White;
            this.btn_flip_leftRight.Location = new System.Drawing.Point(16, 185);
            this.btn_flip_leftRight.Name = "btn_flip_leftRight";
            this.btn_flip_leftRight.Size = new System.Drawing.Size(118, 30);
            this.btn_flip_leftRight.TabIndex = 4;
            this.btn_flip_leftRight.Text = "左右翻轉";
            this.btn_flip_leftRight.UseVisualStyleBackColor = true;
            this.btn_flip_leftRight.Click += new System.EventHandler(this.btn_flip_leftRight_Click);
            // 
            // btn_rotate_right
            // 
            this.btn_rotate_right.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_rotate_right.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_rotate_right.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.btn_rotate_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rotate_right.ForeColor = System.Drawing.Color.White;
            this.btn_rotate_right.Location = new System.Drawing.Point(16, 99);
            this.btn_rotate_right.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btn_rotate_right.Name = "btn_rotate_right";
            this.btn_rotate_right.Size = new System.Drawing.Size(118, 30);
            this.btn_rotate_right.TabIndex = 2;
            this.btn_rotate_right.Text = "向右旋轉90度";
            this.btn_rotate_right.UseVisualStyleBackColor = true;
            this.btn_rotate_right.Click += new System.EventHandler(this.btn_rotate_right_Click);
            // 
            // btn_flip_topBottom
            // 
            this.btn_flip_topBottom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_flip_topBottom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_flip_topBottom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.btn_flip_topBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_flip_topBottom.ForeColor = System.Drawing.Color.White;
            this.btn_flip_topBottom.Location = new System.Drawing.Point(16, 142);
            this.btn_flip_topBottom.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btn_flip_topBottom.Name = "btn_flip_topBottom";
            this.btn_flip_topBottom.Size = new System.Drawing.Size(118, 30);
            this.btn_flip_topBottom.TabIndex = 3;
            this.btn_flip_topBottom.Text = "上下翻轉";
            this.btn_flip_topBottom.UseVisualStyleBackColor = true;
            this.btn_flip_topBottom.Click += new System.EventHandler(this.btn_flip_topBottom_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_tips_dragImage);
            this.panel3.Controls.Add(this.picture_preview);
            this.panel3.Location = new System.Drawing.Point(0, 108);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 509);
            this.panel3.TabIndex = 2;
            // 
            // lbl_tips_dragImage
            // 
            this.lbl_tips_dragImage.AutoSize = true;
            this.lbl_tips_dragImage.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_tips_dragImage.ForeColor = System.Drawing.Color.White;
            this.lbl_tips_dragImage.Location = new System.Drawing.Point(329, 246);
            this.lbl_tips_dragImage.Name = "lbl_tips_dragImage";
            this.lbl_tips_dragImage.Size = new System.Drawing.Size(168, 25);
            this.lbl_tips_dragImage.TabIndex = 1;
            this.lbl_tips_dragImage.Text = "拖放圖片在此";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_cropFrameSize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_title_imgName);
            this.panel1.Controls.Add(this.lbl_imgName);
            this.panel1.Controls.Add(this.lbl_title_cropTotalNum);
            this.panel1.Controls.Add(this.lbl_cropTotalNum);
            this.panel1.Controls.Add(this.lbl_title_imgSize);
            this.panel1.Controls.Add(this.lbl_imgSize);
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 78);
            this.panel1.TabIndex = 1;
            // 
            // lbl_cropFrameSize
            // 
            this.lbl_cropFrameSize.AutoSize = true;
            this.lbl_cropFrameSize.ForeColor = System.Drawing.Color.White;
            this.lbl_cropFrameSize.Location = new System.Drawing.Point(301, 15);
            this.lbl_cropFrameSize.Name = "lbl_cropFrameSize";
            this.lbl_cropFrameSize.Size = new System.Drawing.Size(50, 15);
            this.lbl_cropFrameSize.TabIndex = 8;
            this.lbl_cropFrameSize.Text = "dummy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "截圖的大小: ";
            // 
            // lbl_title_imgName
            // 
            this.lbl_title_imgName.AutoSize = true;
            this.lbl_title_imgName.ForeColor = System.Drawing.Color.White;
            this.lbl_title_imgName.Location = new System.Drawing.Point(15, 15);
            this.lbl_title_imgName.Name = "lbl_title_imgName";
            this.lbl_title_imgName.Size = new System.Drawing.Size(75, 15);
            this.lbl_title_imgName.TabIndex = 6;
            this.lbl_title_imgName.Text = "相片名稱: ";
            // 
            // lbl_imgName
            // 
            this.lbl_imgName.AutoSize = true;
            this.lbl_imgName.ForeColor = System.Drawing.Color.White;
            this.lbl_imgName.Location = new System.Drawing.Point(96, 15);
            this.lbl_imgName.Name = "lbl_imgName";
            this.lbl_imgName.Size = new System.Drawing.Size(50, 15);
            this.lbl_imgName.TabIndex = 5;
            this.lbl_imgName.Text = "dummy";
            // 
            // lbl_title_cropTotalNum
            // 
            this.lbl_title_cropTotalNum.AutoSize = true;
            this.lbl_title_cropTotalNum.ForeColor = System.Drawing.Color.White;
            this.lbl_title_cropTotalNum.Location = new System.Drawing.Point(205, 45);
            this.lbl_title_cropTotalNum.Name = "lbl_title_cropTotalNum";
            this.lbl_title_cropTotalNum.Size = new System.Drawing.Size(120, 15);
            this.lbl_title_cropTotalNum.TabIndex = 4;
            this.lbl_title_cropTotalNum.Text = "截圖的總共數目: ";
            // 
            // lbl_cropTotalNum
            // 
            this.lbl_cropTotalNum.AutoSize = true;
            this.lbl_cropTotalNum.ForeColor = System.Drawing.Color.White;
            this.lbl_cropTotalNum.Location = new System.Drawing.Point(331, 45);
            this.lbl_cropTotalNum.Name = "lbl_cropTotalNum";
            this.lbl_cropTotalNum.Size = new System.Drawing.Size(14, 15);
            this.lbl_cropTotalNum.TabIndex = 3;
            this.lbl_cropTotalNum.Text = "0";
            // 
            // lbl_title_imgSize
            // 
            this.lbl_title_imgSize.AutoSize = true;
            this.lbl_title_imgSize.ForeColor = System.Drawing.Color.White;
            this.lbl_title_imgSize.Location = new System.Drawing.Point(15, 45);
            this.lbl_title_imgSize.Name = "lbl_title_imgSize";
            this.lbl_title_imgSize.Size = new System.Drawing.Size(75, 15);
            this.lbl_title_imgSize.TabIndex = 2;
            this.lbl_title_imgSize.Text = "相片大小: ";
            // 
            // lbl_imgSize
            // 
            this.lbl_imgSize.AutoSize = true;
            this.lbl_imgSize.ForeColor = System.Drawing.Color.White;
            this.lbl_imgSize.Location = new System.Drawing.Point(96, 45);
            this.lbl_imgSize.Name = "lbl_imgSize";
            this.lbl_imgSize.Size = new System.Drawing.Size(50, 15);
            this.lbl_imgSize.TabIndex = 0;
            this.lbl_imgSize.Text = "dummy";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1262, 40);
            this.panel7.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1262, 1);
            this.panel5.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel_fill);
            this.Controls.Add(this.panel_dataInput);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(18, 313);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crop";
            this.panel_scaleSize.ResumeLayout(false);
            this.panel_scaleSize.PerformLayout();
            this.panel_outputDir.ResumeLayout(false);
            this.panel_outputDir.PerformLayout();
            this.panel_imgSource.ResumeLayout(false);
            this.panel_imgSource.PerformLayout();
            this.panel_dimension.ResumeLayout(false);
            this.panel_dimension.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_preview)).EndInit();
            this.panel_dataInput.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_cropDirection.ResumeLayout(false);
            this.panel_cropDirection.PerformLayout();
            this.panel_button.ResumeLayout(false);
            this.panel_fill.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cropFrame_color)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Panel panel_dimension;
        private System.Windows.Forms.ComboBox cb_dimension;
        private System.Windows.Forms.Label lbl_title_dimension;
        private System.Windows.Forms.Panel panel_imgSource;
        private System.Windows.Forms.Label lbl_title_imgSource;
        private System.Windows.Forms.Button btn_fileSelector;
        private System.Windows.Forms.Panel panel_outputDir;
        private System.Windows.Forms.Label lbl_title_outputDir;
        private System.Windows.Forms.Button btn_outputDir;
        private System.Windows.Forms.Panel panel_scaleSize;
        private System.Windows.Forms.Label lbl_title_scaleSize;
        private System.Windows.Forms.TextBox txt_scaleSize;
        private System.Windows.Forms.PictureBox picture_preview;
        private System.Windows.Forms.Panel panel_dataInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Panel panel_fill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title_cropTotalNum;
        private System.Windows.Forms.Label lbl_cropTotalNum;
        private System.Windows.Forms.Label lbl_title_imgSize;
        private System.Windows.Forms.Label lbl_imgSize;
        private System.Windows.Forms.Label lbl_title_imgName;
        private System.Windows.Forms.Label lbl_imgName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_rotate_left;
        private System.Windows.Forms.Button btn_rotate_right;
        private System.Windows.Forms.Button btn_flip_topBottom;
        private System.Windows.Forms.Button btn_flip_leftRight;
        private System.Windows.Forms.Panel panel_cropDirection;
        private System.Windows.Forms.ComboBox cb_cropDirection;
        private System.Windows.Forms.Label lbl_title_cropDirection;
        private System.Windows.Forms.Label lbl_tips_dragImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cropFrameSize;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pb_cropFrame_color;
        private System.Windows.Forms.Label label2;
    }
}

