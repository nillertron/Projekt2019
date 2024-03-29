﻿namespace ProjektOpgave1Sem2019
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
            this.Fornavn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Efternavn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.TBInput = new System.Windows.Forms.TextBox();
            this.DisplayEjendomsmæglerLocation = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayEjendomsmæglerLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(324, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Opret ny ejendomsmægler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.CBKriterie.Location = new System.Drawing.Point(67, 12);
            this.CBKriterie.Margin = new System.Windows.Forms.Padding(2);
            this.CBKriterie.Name = "CBKriterie";
            this.CBKriterie.Size = new System.Drawing.Size(92, 21);
            this.CBKriterie.TabIndex = 1;
            this.CBKriterie.Text = "Navn";
            this.CBKriterie.SelectedIndexChanged += new System.EventHandler(this.CBKriterie_SelectedIndexChanged);
            // 
            // LWSearchResults
            // 
            this.LWSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Fornavn,
            this.Efternavn});
            this.LWSearchResults.FullRowSelect = true;
            this.LWSearchResults.HideSelection = false;
            this.LWSearchResults.Location = new System.Drawing.Point(10, 36);
            this.LWSearchResults.Margin = new System.Windows.Forms.Padding(2);
            this.LWSearchResults.Name = "LWSearchResults";
            this.LWSearchResults.Size = new System.Drawing.Size(310, 419);
            this.LWSearchResults.TabIndex = 4;
            this.LWSearchResults.UseCompatibleStateImageBehavior = false;
            this.LWSearchResults.View = System.Windows.Forms.View.Details;
            this.LWSearchResults.SelectedIndexChanged += new System.EventHandler(this.LWSearchResults_SelectedIndexChanged);
            this.LWSearchResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LWSearchResults_MouseDoubleClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Søg efter: ";
            // 
            // TBInput
            // 
            this.TBInput.Location = new System.Drawing.Point(163, 12);
            this.TBInput.Margin = new System.Windows.Forms.Padding(2);
            this.TBInput.Name = "TBInput";
            this.TBInput.Size = new System.Drawing.Size(128, 20);
            this.TBInput.TabIndex = 2;
            this.TBInput.TextChanged += new System.EventHandler(this.TBInput_TextChanged);
            // 
            // DisplayEjendomsmæglerLocation
            // 
            this.DisplayEjendomsmæglerLocation.Location = new System.Drawing.Point(0, 0);
            this.DisplayEjendomsmæglerLocation.Margin = new System.Windows.Forms.Padding(2);
            this.DisplayEjendomsmæglerLocation.Name = "DisplayEjendomsmæglerLocation";
            this.DisplayEjendomsmæglerLocation.Size = new System.Drawing.Size(8, 10);
            this.DisplayEjendomsmæglerLocation.TabIndex = 7;
            this.DisplayEjendomsmæglerLocation.TabStop = false;
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(327, 47);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(820, 452);
            this.panelContent.TabIndex = 8;
            // 
            // EjendomsmæglereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.DisplayEjendomsmæglerLocation);
            this.Controls.Add(this.TBInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LWSearchResults);
            this.Controls.Add(this.CBKriterie);
            this.Controls.Add(this.button2);
            this.Name = "EjendomsmæglereForm";
            this.Size = new System.Drawing.Size(1148, 500);
            this.Load += new System.EventHandler(this.EjendomsmæglereForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayEjendomsmæglerLocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CBKriterie;
        private System.Windows.Forms.ListView LWSearchResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBInput;
        private System.Windows.Forms.ColumnHeader Fornavn;
        private System.Windows.Forms.ColumnHeader Efternavn;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox DisplayEjendomsmæglerLocation;
        public System.Windows.Forms.Panel panelContent;
    }
}
