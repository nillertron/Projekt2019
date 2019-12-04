namespace ProjektOpgave1Sem2019
{
    partial class BoligForm
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
            this.TBInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LWSearchResults = new System.Windows.Forms.ListView();
            this.Adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PostNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.CBKriterie = new System.Windows.Forms.ComboBox();
            this.btnUdskrivAlleBoligerIkkeSolgt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDatoSøgning = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBInput
            // 
            this.TBInput.Location = new System.Drawing.Point(236, 12);
            this.TBInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBInput.Name = "TBInput";
            this.TBInput.Size = new System.Drawing.Size(169, 22);
            this.TBInput.TabIndex = 11;
            this.TBInput.TextChanged += new System.EventHandler(this.TBInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Søg efter: ";
            // 
            // LWSearchResults
            // 
            this.LWSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Adresse,
            this.PostNr});
            this.LWSearchResults.FullRowSelect = true;
            this.LWSearchResults.HideSelection = false;
            this.LWSearchResults.Location = new System.Drawing.Point(17, 44);
            this.LWSearchResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LWSearchResults.Name = "LWSearchResults";
            this.LWSearchResults.Size = new System.Drawing.Size(412, 515);
            this.LWSearchResults.TabIndex = 9;
            this.LWSearchResults.UseCompatibleStateImageBehavior = false;
            this.LWSearchResults.View = System.Windows.Forms.View.Details;
            this.LWSearchResults.DoubleClick += new System.EventHandler(this.LWSearchResults_DoubleClick);
            // 
            // Adresse
            // 
            this.Adresse.Text = "Adresse";
            this.Adresse.Width = 150;
            // 
            // PostNr
            // 
            this.PostNr.Text = "Post Nr";
            this.PostNr.Width = 150;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(436, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Opret ny bolig";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // CBKriterie
            // 
            this.CBKriterie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBKriterie.FormattingEnabled = true;
            this.CBKriterie.Location = new System.Drawing.Point(68, 12);
            this.CBKriterie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBKriterie.Name = "CBKriterie";
            this.CBKriterie.Size = new System.Drawing.Size(160, 24);
            this.CBKriterie.TabIndex = 12;
            this.CBKriterie.SelectedIndexChanged += new System.EventHandler(this.CBKriterie_SelectedIndexChanged);
            // 
            // btnUdskrivAlleBoligerIkkeSolgt
            // 
            this.btnUdskrivAlleBoligerIkkeSolgt.ForeColor = System.Drawing.Color.Black;
            this.btnUdskrivAlleBoligerIkkeSolgt.Location = new System.Drawing.Point(627, 2);
            this.btnUdskrivAlleBoligerIkkeSolgt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUdskrivAlleBoligerIkkeSolgt.Name = "btnUdskrivAlleBoligerIkkeSolgt";
            this.btnUdskrivAlleBoligerIkkeSolgt.Size = new System.Drawing.Size(185, 46);
            this.btnUdskrivAlleBoligerIkkeSolgt.TabIndex = 13;
            this.btnUdskrivAlleBoligerIkkeSolgt.Text = "Udskriv til txtfil:Ikke solgte boligere";
            this.btnUdskrivAlleBoligerIkkeSolgt.UseVisualStyleBackColor = true;
            this.btnUdskrivAlleBoligerIkkeSolgt.Click += new System.EventHandler(this.btnUdskrivAlleBoligerIkkeSolgt_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(817, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Udskriv til txtfil:Boliger i bestsemt område";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDatoSøgning
            // 
            this.btnDatoSøgning.ForeColor = System.Drawing.Color.Black;
            this.btnDatoSøgning.Location = new System.Drawing.Point(1008, 2);
            this.btnDatoSøgning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatoSøgning.Name = "btnDatoSøgning";
            this.btnDatoSøgning.Size = new System.Drawing.Size(185, 46);
            this.btnDatoSøgning.TabIndex = 15;
            this.btnDatoSøgning.Text = "Statistik over boliger i valgt periode";
            this.btnDatoSøgning.UseVisualStyleBackColor = true;
            this.btnDatoSøgning.Click += new System.EventHandler(this.btnDatoSøgning_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1199, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 46);
            this.button3.TabIndex = 16;
            this.button3.Text = "Udskriv Kundekontrakt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BoligForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDatoSøgning);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUdskrivAlleBoligerIkkeSolgt);
            this.Controls.Add(this.CBKriterie);
            this.Controls.Add(this.TBInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LWSearchResults);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BoligForm";
            this.Size = new System.Drawing.Size(1531, 615);
            this.Load += new System.EventHandler(this.BoligView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LWSearchResults;
        private System.Windows.Forms.ColumnHeader Adresse;
        private System.Windows.Forms.ColumnHeader PostNr;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CBKriterie;
        public System.Windows.Forms.Button btnUdskrivAlleBoligerIkkeSolgt;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnDatoSøgning;
        public System.Windows.Forms.Button button3;
    }
}
