namespace ProjektOpgave1Sem2019
{
    partial class VælgEMæglerForm
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
            this.LBEMæglere = new System.Windows.Forms.ListBox();
            this.BtnVælg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBEMæglere
            // 
            this.LBEMæglere.FormattingEnabled = true;
            this.LBEMæglere.Location = new System.Drawing.Point(13, 13);
            this.LBEMæglere.Name = "LBEMæglere";
            this.LBEMæglere.Size = new System.Drawing.Size(122, 160);
            this.LBEMæglere.TabIndex = 0;
            this.LBEMæglere.SelectedIndexChanged += new System.EventHandler(this.LBEMæglere_SelectedIndexChanged);
            this.LBEMæglere.DoubleClick += new System.EventHandler(this.LBEMæglere_DoubleClick);
            // 
            // BtnVælg
            // 
            this.BtnVælg.ForeColor = System.Drawing.Color.Black;
            this.BtnVælg.Location = new System.Drawing.Point(37, 180);
            this.BtnVælg.Name = "BtnVælg";
            this.BtnVælg.Size = new System.Drawing.Size(75, 23);
            this.BtnVælg.TabIndex = 1;
            this.BtnVælg.Text = "Vælg";
            this.BtnVælg.UseVisualStyleBackColor = true;
            this.BtnVælg.Click += new System.EventHandler(this.BtnVælg_Click);
            // 
            // VælgEMæglerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 220);
            this.Controls.Add(this.BtnVælg);
            this.Controls.Add(this.LBEMæglere);
            this.Name = "VælgEMæglerForm";
            this.Text = "VælgEMæglerForm";
            this.Load += new System.EventHandler(this.VælgEMæglerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBEMæglere;
        private System.Windows.Forms.Button BtnVælg;
    }
}