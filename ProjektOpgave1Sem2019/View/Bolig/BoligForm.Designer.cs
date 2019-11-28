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
            this.SuspendLayout();
            // 
            // TBInput
            // 
            this.TBInput.Location = new System.Drawing.Point(276, 62);
            this.TBInput.Name = "TBInput";
            this.TBInput.Size = new System.Drawing.Size(190, 26);
            this.TBInput.TabIndex = 11;
            this.TBInput.TextChanged += new System.EventHandler(this.TBInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
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
            this.LWSearchResults.Location = new System.Drawing.Point(3, 100);
            this.LWSearchResults.Name = "LWSearchResults";
            this.LWSearchResults.Size = new System.Drawing.Size(463, 642);
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
            this.button2.Location = new System.Drawing.Point(459, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "Opret ny bolig";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // CBKriterie
            // 
            this.CBKriterie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBKriterie.FormattingEnabled = true;
            this.CBKriterie.Location = new System.Drawing.Point(87, 62);
            this.CBKriterie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBKriterie.Name = "CBKriterie";
            this.CBKriterie.Size = new System.Drawing.Size(180, 28);
            this.CBKriterie.TabIndex = 12;
            // 
            // BoligForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CBKriterie);
            this.Controls.Add(this.TBInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LWSearchResults);
            this.Controls.Add(this.button2);
            this.Location = new System.Drawing.Point(200, 116);
            this.Name = "BoligForm";
            this.Size = new System.Drawing.Size(1722, 769);
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
    }
}
