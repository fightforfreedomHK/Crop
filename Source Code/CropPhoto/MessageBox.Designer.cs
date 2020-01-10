namespace CropPhoto
{
    partial class MessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_msg = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_msg
            // 
            this.lbl_msg.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_msg.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_msg.Location = new System.Drawing.Point(0, 0);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(344, 72);
            this.lbl_msg.TabIndex = 0;
            this.lbl_msg.Text = "XXXXX";
            this.lbl_msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ok.Location = new System.Drawing.Point(134, 75);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 110);
            this.ControlBox = false;
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_msg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBox";
            this.Text = "提示";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_ok;
        public System.Windows.Forms.Label lbl_msg;
    }
}