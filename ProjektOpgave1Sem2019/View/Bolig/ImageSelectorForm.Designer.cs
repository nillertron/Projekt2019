namespace ProjektOpgave1Sem2019.View.Bolig
{
    partial class ImageSelectorForm
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
            this.LBPictures = new System.Windows.Forms.ListBox();
            this.PBSelectedPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBSelectedPic)).BeginInit();
            this.SuspendLayout();
            // 
            // LBPictures
            // 
            this.LBPictures.FormattingEnabled = true;
            this.LBPictures.Location = new System.Drawing.Point(13, 13);
            this.LBPictures.Name = "LBPictures";
            this.LBPictures.Size = new System.Drawing.Size(145, 368);
            this.LBPictures.TabIndex = 0;
            this.LBPictures.SelectedIndexChanged += new System.EventHandler(this.LBPictures_SelectedIndexChanged);
            // 
            // PBSelectedPic
            // 
            this.PBSelectedPic.Location = new System.Drawing.Point(186, 13);
            this.PBSelectedPic.Name = "PBSelectedPic";
            this.PBSelectedPic.Size = new System.Drawing.Size(483, 368);
            this.PBSelectedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSelectedPic.TabIndex = 1;
            this.PBSelectedPic.TabStop = false;
            // 
            // ImageSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PBSelectedPic);
            this.Controls.Add(this.LBPictures);
            this.Name = "ImageSelectorForm";
            this.Text = "ImageSelectorForm";
            this.Load += new System.EventHandler(this.ImageSelectorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBSelectedPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBPictures;
        private System.Windows.Forms.PictureBox PBSelectedPic;
    }
}