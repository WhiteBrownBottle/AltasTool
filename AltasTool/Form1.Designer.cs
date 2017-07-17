namespace AltasTool
{
    partial class AltasTool
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnPrase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(23, 12);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(238, 199);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // btnPrase
            // 
            this.btnPrase.Location = new System.Drawing.Point(23, 219);
            this.btnPrase.Name = "btnPrase";
            this.btnPrase.Size = new System.Drawing.Size(238, 23);
            this.btnPrase.TabIndex = 1;
            this.btnPrase.Text = "解析";
            this.btnPrase.UseVisualStyleBackColor = true;
            this.btnPrase.Click += new System.EventHandler(this.btnPrase_Click);
            this.btnPrase.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnPrase_DragEnter);
            // 
            // AltasTool
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(282, 254);
            this.Controls.Add(this.btnPrase);
            this.Controls.Add(this.picImage);
            this.MaximizeBox = false;
            this.Name = "AltasTool";
            this.Text = "AltasTool";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.AltasTool_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.AltasTool_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnPrase;
    }
}

