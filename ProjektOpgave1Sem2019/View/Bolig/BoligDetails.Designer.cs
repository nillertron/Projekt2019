namespace ProjektOpgave1Sem2019
{
    partial class BoligDetails
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
            this.TBAdresse = new System.Windows.Forms.TextBox();
            this.TBPris = new System.Windows.Forms.TextBox();
            this.LabelID = new System.Windows.Forms.Label();
            this.TBAreal = new System.Windows.Forms.TextBox();
            this.DTPOpretDato = new System.Windows.Forms.DateTimePicker();
            this.CBPostNr = new System.Windows.Forms.ComboBox();
            this.TBPostNr = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LabelMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBAdresse
            // 
            this.TBAdresse.Location = new System.Drawing.Point(23, 133);
            this.TBAdresse.Name = "TBAdresse";
            this.TBAdresse.Size = new System.Drawing.Size(153, 26);
            this.TBAdresse.TabIndex = 0;
            // 
            // TBPris
            // 
            this.TBPris.Location = new System.Drawing.Point(23, 46);
            this.TBPris.Name = "TBPris";
            this.TBPris.Size = new System.Drawing.Size(153, 26);
            this.TBPris.TabIndex = 1;
            this.TBPris.TextChanged += new System.EventHandler(this.TBPris_TextChanged);
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(231, 49);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(34, 20);
            this.LabelID.TabIndex = 2;
            this.LabelID.Text = "ID: ";
            // 
            // TBAreal
            // 
            this.TBAreal.Location = new System.Drawing.Point(23, 213);
            this.TBAreal.Name = "TBAreal";
            this.TBAreal.Size = new System.Drawing.Size(79, 26);
            this.TBAreal.TabIndex = 3;
            this.TBAreal.TextChanged += new System.EventHandler(this.TBAreal_TextChanged);
            // 
            // DTPOpretDato
            // 
            this.DTPOpretDato.Location = new System.Drawing.Point(23, 280);
            this.DTPOpretDato.Name = "DTPOpretDato";
            this.DTPOpretDato.Size = new System.Drawing.Size(200, 26);
            this.DTPOpretDato.TabIndex = 4;
            // 
            // CBPostNr
            // 
            this.CBPostNr.FormattingEnabled = true;
            this.CBPostNr.Location = new System.Drawing.Point(235, 131);
            this.CBPostNr.Name = "CBPostNr";
            this.CBPostNr.Size = new System.Drawing.Size(121, 28);
            this.CBPostNr.TabIndex = 5;
            // 
            // TBPostNr
            // 
            this.TBPostNr.Location = new System.Drawing.Point(235, 131);
            this.TBPostNr.Name = "TBPostNr";
            this.TBPostNr.Size = new System.Drawing.Size(121, 26);
            this.TBPostNr.TabIndex = 6;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(23, 355);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(170, 51);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LabelMode
            // 
            this.LabelMode.AutoSize = true;
            this.LabelMode.Location = new System.Drawing.Point(23, 4);
            this.LabelMode.Name = "LabelMode";
            this.LabelMode.Size = new System.Drawing.Size(51, 20);
            this.LabelMode.TabIndex = 8;
            this.LabelMode.Text = "label1";
            // 
            // BoligDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelMode);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TBPostNr);
            this.Controls.Add(this.CBPostNr);
            this.Controls.Add(this.DTPOpretDato);
            this.Controls.Add(this.TBAreal);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.TBPris);
            this.Controls.Add(this.TBAdresse);
            this.Name = "BoligDetails";
            this.Size = new System.Drawing.Size(1020, 444);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBAdresse;
        private System.Windows.Forms.TextBox TBPris;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.TextBox TBAreal;
        private System.Windows.Forms.DateTimePicker DTPOpretDato;
        private System.Windows.Forms.ComboBox CBPostNr;
        private System.Windows.Forms.TextBox TBPostNr;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LabelMode;
    }
}
