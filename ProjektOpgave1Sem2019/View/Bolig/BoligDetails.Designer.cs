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
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.CBPostNr = new System.Windows.Forms.ComboBox();
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
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
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
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(15, 182);
            this.DTP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(135, 20);
            this.DTP.TabIndex = 4;
            // 
            // CBPostNr
            // 
            this.CBPostNr.FormattingEnabled = true;
            this.CBPostNr.Location = new System.Drawing.Point(157, 85);
            this.CBPostNr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBPostNr.Name = "CBPostNr";
            this.CBPostNr.Size = new System.Drawing.Size(82, 21);
            this.CBPostNr.TabIndex = 5;
            // 
            // BoligDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CBPostNr);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.TBAreal);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.TBPris);
            this.Controls.Add(this.TBAdresse);
            this.Location = new System.Drawing.Point(470, 66);
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
        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.ComboBox CBPostNr;
    }
}
