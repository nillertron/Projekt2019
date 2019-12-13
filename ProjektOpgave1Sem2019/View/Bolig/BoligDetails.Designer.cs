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
            this.BtnVælgE = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TBEMæglerNavn = new System.Windows.Forms.TextBox();
            this.BtnVælgSælger = new System.Windows.Forms.Button();
            this.TBValgtSælger = new System.Windows.Forms.TextBox();
            this.lblPost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBAdresse
            // 
            this.TBAdresse.Location = new System.Drawing.Point(20, 106);
            this.TBAdresse.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TBAdresse.Name = "TBAdresse";
            this.TBAdresse.Size = new System.Drawing.Size(136, 22);
            this.TBAdresse.TabIndex = 1;
            this.TBAdresse.TextChanged += new System.EventHandler(this.TBAdresse_TextChanged);
            // 
            // TBPris
            // 
            this.TBPris.Location = new System.Drawing.Point(20, 37);
            this.TBPris.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TBPris.Name = "TBPris";
            this.TBPris.Size = new System.Drawing.Size(136, 22);
            this.TBPris.TabIndex = 0;
            this.TBPris.TextChanged += new System.EventHandler(this.TBPris_TextChanged);
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.ForeColor = System.Drawing.Color.Black;
            this.LabelID.Location = new System.Drawing.Point(205, 39);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(29, 17);
            this.LabelID.TabIndex = 2;
            this.LabelID.Text = "ID: ";
            // 
            // TBAreal
            // 
            this.TBAreal.Location = new System.Drawing.Point(20, 170);
            this.TBAreal.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TBAreal.Name = "TBAreal";
            this.TBAreal.Size = new System.Drawing.Size(71, 22);
            this.TBAreal.TabIndex = 3;
            this.TBAreal.TextChanged += new System.EventHandler(this.TBAreal_TextChanged);
            // 
            // DTPOpretDato
            // 
            this.DTPOpretDato.Location = new System.Drawing.Point(20, 224);
            this.DTPOpretDato.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.DTPOpretDato.Name = "DTPOpretDato";
            this.DTPOpretDato.Size = new System.Drawing.Size(179, 22);
            this.DTPOpretDato.TabIndex = 6;
            // 
            // CBPostNr
            // 
            this.CBPostNr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPostNr.FormattingEnabled = true;
            this.CBPostNr.Location = new System.Drawing.Point(209, 105);
            this.CBPostNr.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.CBPostNr.Name = "CBPostNr";
            this.CBPostNr.Size = new System.Drawing.Size(108, 24);
            this.CBPostNr.TabIndex = 5;
            this.CBPostNr.SelectedIndexChanged += new System.EventHandler(this.CBPostNr_SelectedIndexChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.ForeColor = System.Drawing.Color.Black;
            this.BtnSave.Location = new System.Drawing.Point(20, 284);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(151, 41);
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
            this.LabelMode.Location = new System.Drawing.Point(385, 25);
            this.LabelMode.Name = "LabelMode";
            this.LabelMode.Size = new System.Drawing.Size(81, 31);
            this.LabelMode.TabIndex = 8;
            this.LabelMode.Text = "Mode";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.ForeColor = System.Drawing.Color.Black;
            this.Adresse.Location = new System.Drawing.Point(16, 87);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(60, 17);
            this.Adresse.TabIndex = 9;
            this.Adresse.Text = "Adresse";
            // 
            // PostNr
            // 
            this.PostNr.AutoSize = true;
            this.PostNr.ForeColor = System.Drawing.Color.Black;
            this.PostNr.Location = new System.Drawing.Point(205, 87);
            this.PostNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PostNr.Name = "PostNr";
            this.PostNr.Size = new System.Drawing.Size(55, 17);
            this.PostNr.TabIndex = 10;
            this.PostNr.Text = "Post Nr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Areal";
            // 
            // LBLForslåetPris
            // 
            this.LBLForslåetPris.AutoSize = true;
            this.LBLForslåetPris.ForeColor = System.Drawing.Color.Black;
            this.LBLForslåetPris.Location = new System.Drawing.Point(205, 138);
            this.LBLForslåetPris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLForslåetPris.Name = "LBLForslåetPris";
            this.LBLForslåetPris.Size = new System.Drawing.Size(221, 17);
            this.LBLForslåetPris.TabIndex = 12;
            this.LBLForslåetPris.Text = "Forslået pris pr m2 i dette område";
            // 
            // TBPostNr
            // 
            this.TBPostNr.Location = new System.Drawing.Point(209, 105);
            this.TBPostNr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBPostNr.Name = "TBPostNr";
            this.TBPostNr.Size = new System.Drawing.Size(132, 22);
            this.TBPostNr.TabIndex = 2;
            this.TBPostNr.TextChanged += new System.EventHandler(this.TBPostNr_TextChanged);
            // 
            // LBLPris
            // 
            this.LBLPris.AutoSize = true;
            this.LBLPris.ForeColor = System.Drawing.Color.Black;
            this.LBLPris.Location = new System.Drawing.Point(205, 165);
            this.LBLPris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLPris.Name = "LBLPris";
            this.LBLPris.Size = new System.Drawing.Size(82, 17);
            this.LBLPris.TabIndex = 14;
            this.LBLPris.Text = "placeholder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pris";
            // 
            // BTNSolgt
            // 
            this.BTNSolgt.ForeColor = System.Drawing.Color.Black;
            this.BTNSolgt.Location = new System.Drawing.Point(392, 284);
            this.BTNSolgt.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.BTNSolgt.Name = "BTNSolgt";
            this.BTNSolgt.Size = new System.Drawing.Size(151, 41);
            this.BTNSolgt.TabIndex = 9;
            this.BTNSolgt.Text = "Marker solgt";
            this.BTNSolgt.UseVisualStyleBackColor = true;
            this.BTNSolgt.Click += new System.EventHandler(this.BTNSolgt_Click);
            // 
            // BtnVælgE
            // 
            this.BtnVælgE.ForeColor = System.Drawing.Color.Black;
            this.BtnVælgE.Location = new System.Drawing.Point(219, 224);
            this.BtnVælgE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnVælgE.Name = "BtnVælgE";
            this.BtnVælgE.Size = new System.Drawing.Size(100, 28);
            this.BtnVælgE.TabIndex = 5;
            this.BtnVælgE.Text = "Vælg E";
            this.BtnVælgE.UseVisualStyleBackColor = true;
            this.BtnVælgE.Click += new System.EventHandler(this.BtnVælgE_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Location = new System.Drawing.Point(192, 284);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(127, 41);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TBEMæglerNavn
            // 
            this.TBEMæglerNavn.ForeColor = System.Drawing.Color.Black;
            this.TBEMæglerNavn.Location = new System.Drawing.Point(327, 228);
            this.TBEMæglerNavn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBEMæglerNavn.Name = "TBEMæglerNavn";
            this.TBEMæglerNavn.Size = new System.Drawing.Size(132, 22);
            this.TBEMæglerNavn.TabIndex = 20;
            // 
            // BtnVælgSælger
            // 
            this.BtnVælgSælger.ForeColor = System.Drawing.Color.Black;
            this.BtnVælgSælger.Location = new System.Drawing.Point(219, 191);
            this.BtnVælgSælger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVælgSælger.Name = "BtnVælgSælger";
            this.BtnVælgSælger.Size = new System.Drawing.Size(97, 26);
            this.BtnVælgSælger.TabIndex = 4;
            this.BtnVælgSælger.Text = "Vælg S";
            this.BtnVælgSælger.UseVisualStyleBackColor = true;
            this.BtnVælgSælger.Click += new System.EventHandler(this.BtnVælgSælger_Click);
            // 
            // TBValgtSælger
            // 
            this.TBValgtSælger.Location = new System.Drawing.Point(327, 196);
            this.TBValgtSælger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBValgtSælger.Name = "TBValgtSælger";
            this.TBValgtSælger.Size = new System.Drawing.Size(132, 22);
            this.TBValgtSælger.TabIndex = 22;
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.ForeColor = System.Drawing.Color.Black;
            this.lblPost.Location = new System.Drawing.Point(351, 110);
            this.lblPost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(0, 17);
            this.lblPost.TabIndex = 23;
            // 
            // BoligDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.TBValgtSælger);
            this.Controls.Add(this.BtnVælgSælger);
            this.Controls.Add(this.TBEMæglerNavn);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnVælgE);
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
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "BoligDetails";
            this.Size = new System.Drawing.Size(907, 356);
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
        public System.Windows.Forms.Button BTNSolgt;
        private System.Windows.Forms.Button BtnVælgE;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TBEMæglerNavn;
        private System.Windows.Forms.Button BtnVælgSælger;
        private System.Windows.Forms.TextBox TBValgtSælger;
        private System.Windows.Forms.Label lblPost;
    }
}
