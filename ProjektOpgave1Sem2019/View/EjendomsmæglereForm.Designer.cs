namespace ProjektOpgave1Sem2019
{
    partial class EjendomsmæglereForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.CBKriterie = new System.Windows.Forms.ComboBox();
            this.LWSearchResults = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.TBInput = new System.Windows.Forms.TextBox();
            this.Fornavn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Efternavn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(419, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Opret ny ejendomsmægler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CBKriterie
            // 
            this.CBKriterie.FormattingEnabled = true;
            this.CBKriterie.Items.AddRange(new object[] {
            "Navn",
            "Fornavn",
            "Efternavn",
            "FødselsDato",
            "Tlf"});
            this.CBKriterie.Location = new System.Drawing.Point(97, 67);
            this.CBKriterie.Name = "CBKriterie";
            this.CBKriterie.Size = new System.Drawing.Size(121, 24);
            this.CBKriterie.TabIndex = 3;
            this.CBKriterie.Text = "Navn";
            // 
            // LWSearchResults
            // 
            this.LWSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Fornavn,
            this.Efternavn});
            this.LWSearchResults.FullRowSelect = true;
            this.LWSearchResults.HideSelection = false;
            this.LWSearchResults.Location = new System.Drawing.Point(13, 97);
            this.LWSearchResults.Name = "LWSearchResults";
            this.LWSearchResults.Size = new System.Drawing.Size(412, 515);
            this.LWSearchResults.TabIndex = 4;
            this.LWSearchResults.UseCompatibleStateImageBehavior = false;
            this.LWSearchResults.View = System.Windows.Forms.View.Details;
            this.LWSearchResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LWSearchResults_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Søg efter: ";
            // 
            // TBInput
            // 
            this.TBInput.Location = new System.Drawing.Point(256, 67);
            this.TBInput.Name = "TBInput";
            this.TBInput.Size = new System.Drawing.Size(169, 22);
            this.TBInput.TabIndex = 6;
            this.TBInput.TextChanged += new System.EventHandler(this.TBInput_TextChanged);
            // 
            // Fornavn
            // 
            this.Fornavn.Text = "Fornavn";
            this.Fornavn.Width = 150;
            // 
            // Efternavn
            // 
            this.Efternavn.Text = "Efternavn";
            this.Efternavn.Width = 150;
            // 
            // EjendomsmæglereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.TBInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LWSearchResults);
            this.Controls.Add(this.CBKriterie);
            this.Controls.Add(this.button2);
            this.Location = new System.Drawing.Point(200, 116);
            this.Name = "EjendomsmæglereForm";
            this.Size = new System.Drawing.Size(1531, 615);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CBKriterie;
        private System.Windows.Forms.ListView LWSearchResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBInput;
        private System.Windows.Forms.ColumnHeader Fornavn;
        private System.Windows.Forms.ColumnHeader Efternavn;
    }
}
