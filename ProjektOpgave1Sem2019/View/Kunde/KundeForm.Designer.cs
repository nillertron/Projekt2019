namespace ProjektOpgave1Sem2019
{
    partial class KundeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CBKriterie = new System.Windows.Forms.ComboBox();
            this.TBInput = new System.Windows.Forms.TextBox();
            this.LWSearchResults = new System.Windows.Forms.ListView();
            this.Fornavn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Efternavn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnMode = new System.Windows.Forms.Button();
            this.LabelMode = new System.Windows.Forms.Label();
            this.BtnOpret = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Søg efter:";
            // 
            // CBKriterie
            // 
            this.CBKriterie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBKriterie.FormattingEnabled = true;
            this.CBKriterie.Location = new System.Drawing.Point(104, 44);
            this.CBKriterie.Name = "CBKriterie";
            this.CBKriterie.Size = new System.Drawing.Size(121, 21);
            this.CBKriterie.TabIndex = 1;
            // 
            // TBInput
            // 
            this.TBInput.Location = new System.Drawing.Point(231, 44);
            this.TBInput.Name = "TBInput";
            this.TBInput.Size = new System.Drawing.Size(108, 20);
            this.TBInput.TabIndex = 2;
            this.TBInput.TextChanged += new System.EventHandler(this.TBInput_TextChanged);
            // 
            // LWSearchResults
            // 
            this.LWSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Fornavn,
            this.Efternavn});
            this.LWSearchResults.FullRowSelect = true;
            this.LWSearchResults.HideSelection = false;
            this.LWSearchResults.Location = new System.Drawing.Point(48, 72);
            this.LWSearchResults.MultiSelect = false;
            this.LWSearchResults.Name = "LWSearchResults";
            this.LWSearchResults.Size = new System.Drawing.Size(322, 416);
            this.LWSearchResults.TabIndex = 5;
            this.LWSearchResults.UseCompatibleStateImageBehavior = false;
            this.LWSearchResults.View = System.Windows.Forms.View.Details;
            this.LWSearchResults.DoubleClick += new System.EventHandler(this.LWSearchResults_DoubleClick);
            // 
            // Fornavn
            // 
            this.Fornavn.Text = "Fornavn";
            this.Fornavn.Width = 171;
            // 
            // Efternavn
            // 
            this.Efternavn.Text = "Efternavn";
            this.Efternavn.Width = 142;
            // 
            // BtnMode
            // 
            this.BtnMode.ForeColor = System.Drawing.Color.Black;
            this.BtnMode.Location = new System.Drawing.Point(340, 12);
            this.BtnMode.Name = "BtnMode";
            this.BtnMode.Size = new System.Drawing.Size(115, 23);
            this.BtnMode.TabIndex = 3;
            this.BtnMode.Text = "Skift til Sælgermode";
            this.BtnMode.UseVisualStyleBackColor = true;
            this.BtnMode.Click += new System.EventHandler(this.BtnMode_Click);
            // 
            // LabelMode
            // 
            this.LabelMode.AutoSize = true;
            this.LabelMode.BackColor = System.Drawing.Color.Gray;
            this.LabelMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMode.ForeColor = System.Drawing.Color.Maroon;
            this.LabelMode.Location = new System.Drawing.Point(4, 4);
            this.LabelMode.Name = "LabelMode";
            this.LabelMode.Size = new System.Drawing.Size(160, 31);
            this.LabelMode.TabIndex = 5;
            this.LabelMode.Text = "Køber mode";
            // 
            // BtnOpret
            // 
            this.BtnOpret.ForeColor = System.Drawing.Color.Black;
            this.BtnOpret.Location = new System.Drawing.Point(478, 44);
            this.BtnOpret.Name = "BtnOpret";
            this.BtnOpret.Size = new System.Drawing.Size(116, 31);
            this.BtnOpret.TabIndex = 4;
            this.BtnOpret.Text = "Opret Køber";
            this.BtnOpret.UseVisualStyleBackColor = true;
            this.BtnOpret.Click += new System.EventHandler(this.BtnOpret_Click);
            // 
            // KundeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnOpret);
            this.Controls.Add(this.LabelMode);
            this.Controls.Add(this.BtnMode);
            this.Controls.Add(this.LWSearchResults);
            this.Controls.Add(this.TBInput);
            this.Controls.Add(this.CBKriterie);
            this.Controls.Add(this.label1);
            this.Name = "KundeForm";
            this.Size = new System.Drawing.Size(1148, 500);
            this.Load += new System.EventHandler(this.KundeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBKriterie;
        private System.Windows.Forms.TextBox TBInput;
        private System.Windows.Forms.ListView LWSearchResults;
        private System.Windows.Forms.ColumnHeader Fornavn;
        private System.Windows.Forms.ColumnHeader Efternavn;
        private System.Windows.Forms.Button BtnMode;
        private System.Windows.Forms.Label LabelMode;
        private System.Windows.Forms.Button BtnOpret;
    }
}
