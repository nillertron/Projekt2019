namespace ProjektOpgave1Sem2019
{
    partial class VælgSælgerForm
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
            this.LBSælgere = new System.Windows.Forms.ListBox();
            this.BtnVælg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBSælgere
            // 
            this.LBSælgere.FormattingEnabled = true;
            this.LBSælgere.Location = new System.Drawing.Point(13, 13);
            this.LBSælgere.Name = "LBSælgere";
            this.LBSælgere.Size = new System.Drawing.Size(120, 134);
            this.LBSælgere.TabIndex = 0;
            this.LBSælgere.SelectedIndexChanged += new System.EventHandler(this.LBSælgere_SelectedIndexChanged);
            // 
            // BtnVælg
            // 
            this.BtnVælg.Location = new System.Drawing.Point(38, 159);
            this.BtnVælg.Name = "BtnVælg";
            this.BtnVælg.Size = new System.Drawing.Size(75, 23);
            this.BtnVælg.TabIndex = 1;
            this.BtnVælg.Text = "Vælg";
            this.BtnVælg.UseVisualStyleBackColor = true;
            this.BtnVælg.Click += new System.EventHandler(this.BtnVælg_Click);
            // 
            // VælgSælgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVælg);
            this.Controls.Add(this.LBSælgere);
            this.Name = "VælgSælgerForm";
            this.Text = "VælgSælgerForm";
            this.Load += new System.EventHandler(this.VælgSælgerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBSælgere;
        private System.Windows.Forms.Button BtnVælg;
    }
}