namespace ProjektOpgave1Sem2019.View.Bolig
{
    partial class BoligSøgning
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbPostNr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnUdskriv = new System.Windows.Forms.Button();
            this.lblBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbPostNr
            // 
            this.cbPostNr.FormattingEnabled = true;
            this.cbPostNr.Location = new System.Drawing.Point(0, 32);
            this.cbPostNr.Name = "cbPostNr";
            this.cbPostNr.Size = new System.Drawing.Size(121, 21);
            this.cbPostNr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vælg postnummer";
            // 
            // tbSti
            // 
            this.tbSti.Location = new System.Drawing.Point(0, 96);
            this.tbSti.Name = "tbSti";
            this.tbSti.Size = new System.Drawing.Size(239, 20);
            this.tbSti.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vælg sti";
            // 
            // btnBrowse
            // 
            this.btnBrowse.ForeColor = System.Drawing.Color.Black;
            this.btnBrowse.Location = new System.Drawing.Point(245, 93);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnUdskriv
            // 
            this.btnUdskriv.ForeColor = System.Drawing.Color.Black;
            this.btnUdskriv.Location = new System.Drawing.Point(3, 134);
            this.btnUdskriv.Name = "btnUdskriv";
            this.btnUdskriv.Size = new System.Drawing.Size(75, 23);
            this.btnUdskriv.TabIndex = 4;
            this.btnUdskriv.Text = "Udskriv";
            this.btnUdskriv.UseVisualStyleBackColor = true;
            this.btnUdskriv.Click += new System.EventHandler(this.btnUdskriv_Click);
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.ForeColor = System.Drawing.Color.Black;
            this.lblBy.Location = new System.Drawing.Point(139, 39);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(0, 13);
            this.lblBy.TabIndex = 6;
            // 
            // BoligSøgning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBy);
            this.Controls.Add(this.btnUdskriv);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPostNr);
            this.Name = "BoligSøgning";
            this.Size = new System.Drawing.Size(680, 289);
            this.Load += new System.EventHandler(this.BoligSøgning_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPostNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tbSti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnUdskriv;
        private System.Windows.Forms.Label lblBy;
    }
}
