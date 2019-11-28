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
            this.BtnSave = new System.Windows.Forms.Button();
            this.LabelMode = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.PostNr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLForslåetPris = new System.Windows.Forms.Label();
            this.TBPostNr = new System.Windows.Forms.TextBox();
            this.LBLPris = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNSolgt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBAdresse
            // 
            this.TBAdresse.Location = new System.Drawing.Point(15, 86);
            this.TBAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBAdresse.Name = "TBAdresse";
            this.TBAdresse.Size = new System.Drawing.Size(103, 20);
            this.TBAdresse.TabIndex = 0;
            // 
            // TBPris
            // 
            this.TBPris.Location = new System.Drawing.Point(15, 30);
            this.TBPris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBPris.Name = "TBPris";
            this.TBPris.Size = new System.Drawing.Size(103, 20);
            this.TBPris.TabIndex = 1;
            this.TBPris.TextChanged += new System.EventHandler(this.TBPris_TextChanged);
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.ForeColor = System.Drawing.Color.Black;
            this.LabelID.Location = new System.Drawing.Point(154, 32);
            this.LabelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(24, 13);
            this.LabelID.TabIndex = 2;
            this.LabelID.Text = "ID: ";
            // 
            // TBAreal
            // 
            this.TBAreal.Location = new System.Drawing.Point(15, 138);
            this.TBAreal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBAreal.Name = "TBAreal";
            this.TBAreal.Size = new System.Drawing.Size(54, 20);
            this.TBAreal.TabIndex = 3;
            this.TBAreal.TextChanged += new System.EventHandler(this.TBAreal_TextChanged);
            // 
            // DTPOpretDato
            // 
            this.DTPOpretDato.Location = new System.Drawing.Point(15, 182);
            this.DTPOpretDato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTPOpretDato.Name = "DTPOpretDato";
            this.DTPOpretDato.Size = new System.Drawing.Size(135, 20);
            this.DTPOpretDato.TabIndex = 4;
            // 
            // CBPostNr
            // 
            this.CBPostNr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPostNr.FormattingEnabled = true;
            this.CBPostNr.Location = new System.Drawing.Point(157, 85);
            this.CBPostNr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBPostNr.Name = "CBPostNr";
            this.CBPostNr.Size = new System.Drawing.Size(82, 21);
            this.CBPostNr.TabIndex = 5;
            this.CBPostNr.SelectedIndexChanged += new System.EventHandler(this.CBPostNr_SelectedIndexChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(15, 231);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(113, 33);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LabelMode
            // 
            this.LabelMode.AutoSize = true;
            this.LabelMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMode.ForeColor = System.Drawing.Color.Black;
            this.LabelMode.Location = new System.Drawing.Point(289, 20);
            this.LabelMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMode.Name = "LabelMode";
            this.LabelMode.Size = new System.Drawing.Size(66, 25);
            this.LabelMode.TabIndex = 8;
            this.LabelMode.Text = "Mode";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.ForeColor = System.Drawing.Color.Black;
            this.Adresse.Location = new System.Drawing.Point(12, 71);
            this.Adresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(45, 13);
            this.Adresse.TabIndex = 9;
            this.Adresse.Text = "Adresse";
            // 
            // PostNr
            // 
            this.PostNr.AutoSize = true;
            this.PostNr.ForeColor = System.Drawing.Color.Black;
            this.PostNr.Location = new System.Drawing.Point(154, 71);
            this.PostNr.Name = "PostNr";
            this.PostNr.Size = new System.Drawing.Size(42, 13);
            this.PostNr.TabIndex = 10;
            this.PostNr.Text = "Post Nr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Areal";
            // 
            // LBLForslåetPris
            // 
            this.LBLForslåetPris.AutoSize = true;
            this.LBLForslåetPris.ForeColor = System.Drawing.Color.Black;
            this.LBLForslåetPris.Location = new System.Drawing.Point(154, 123);
            this.LBLForslåetPris.Name = "LBLForslåetPris";
            this.LBLForslåetPris.Size = new System.Drawing.Size(162, 13);
            this.LBLForslåetPris.TabIndex = 12;
            this.LBLForslåetPris.Text = "Forslået pris pr m2 i dette område";
            // 
            // TBPostNr
            // 
            this.TBPostNr.Location = new System.Drawing.Point(157, 85);
            this.TBPostNr.Name = "TBPostNr";
            this.TBPostNr.Size = new System.Drawing.Size(100, 20);
            this.TBPostNr.TabIndex = 13;
            // 
            // LBLPris
            // 
            this.LBLPris.AutoSize = true;
            this.LBLPris.ForeColor = System.Drawing.Color.Black;
            this.LBLPris.Location = new System.Drawing.Point(154, 145);
            this.LBLPris.Name = "LBLPris";
            this.LBLPris.Size = new System.Drawing.Size(62, 13);
            this.LBLPris.TabIndex = 14;
            this.LBLPris.Text = "placeholder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pris";
            // 
            // BTNSolgt
            // 
            this.BTNSolgt.Location = new System.Drawing.Point(294, 231);
            this.BTNSolgt.Margin = new System.Windows.Forms.Padding(2);
            this.BTNSolgt.Name = "BTNSolgt";
            this.BTNSolgt.Size = new System.Drawing.Size(113, 33);
            this.BTNSolgt.TabIndex = 16;
            this.BTNSolgt.Text = "Marker solgt";
            this.BTNSolgt.UseVisualStyleBackColor = true;
            this.BTNSolgt.Click += new System.EventHandler(this.BTNSolgt_Click);
            // 
            // BoligDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTNSolgt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBLPris);
            this.Controls.Add(this.TBPostNr);
            this.Controls.Add(this.LBLForslåetPris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PostNr);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.LabelMode);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CBPostNr);
            this.Controls.Add(this.DTPOpretDato);
            this.Controls.Add(this.TBAreal);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.TBPris);
            this.Controls.Add(this.TBAdresse);
            this.Location = new System.Drawing.Point(600, 50);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BoligDetails";
            this.Size = new System.Drawing.Size(680, 289);
            this.Load += new System.EventHandler(this.BoligDetails_Load);
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
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LabelMode;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.Label PostNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLForslåetPris;
        private System.Windows.Forms.TextBox TBPostNr;
        private System.Windows.Forms.Label LBLPris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNSolgt;
    }
}
