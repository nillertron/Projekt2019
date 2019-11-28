namespace ProjektOpgave1Sem2019.View.Bolig
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
            this.SuspendLayout();
            // 
            // TBAdresse
            // 
            this.TBAdresse.Location = new System.Drawing.Point(23, 46);
            this.TBAdresse.Name = "TBAdresse";
            this.TBAdresse.Size = new System.Drawing.Size(153, 26);
            this.TBAdresse.TabIndex = 0;
            // 
            // TBPris
            // 
            this.TBPris.Location = new System.Drawing.Point(23, 134);
            this.TBPris.Name = "TBPris";
            this.TBPris.Size = new System.Drawing.Size(153, 26);
            this.TBPris.TabIndex = 1;
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
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(23, 280);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(200, 26);
            this.DTP.TabIndex = 4;
            // 
            // BoligDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DTP);
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
        private System.Windows.Forms.DateTimePicker DTP;
    }
}
