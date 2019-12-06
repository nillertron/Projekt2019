namespace ProjektOpgave1Sem2019
{
    partial class DatoSøgning
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
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpSlut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LwResultater = new System.Windows.Forms.ListView();
            this.Ejendomsmægler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TbPrisKriterie = new System.Windows.Forms.TextBox();
            this.SolgteBoligerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblPris = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(0, 41);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(265, 22);
            this.dtpStart.TabIndex = 1;
            // 
            // dtpSlut
            // 
            this.dtpSlut.Location = new System.Drawing.Point(0, 91);
            this.dtpSlut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpSlut.Name = "dtpSlut";
            this.dtpSlut.Size = new System.Drawing.Size(265, 22);
            this.dtpSlut.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Slut Dato";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(8, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LwResultater
            // 
            this.LwResultater.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ejendomsmægler,
            this.SolgteBoligerID});
            this.LwResultater.HideSelection = false;
            this.LwResultater.Location = new System.Drawing.Point(345, 41);
            this.LwResultater.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LwResultater.Name = "LwResultater";
            this.LwResultater.Size = new System.Drawing.Size(524, 275);
            this.LwResultater.TabIndex = 6;
            this.LwResultater.UseCompatibleStateImageBehavior = false;
            this.LwResultater.View = System.Windows.Forms.View.Details;
            // 
            // Ejendomsmægler
            // 
            this.Ejendomsmægler.Text = "EjendomsmæglerID";
            this.Ejendomsmægler.Width = 142;
            // 
            // TbPrisKriterie
            // 
            this.TbPrisKriterie.Location = new System.Drawing.Point(718, 322);
            this.TbPrisKriterie.Name = "TbPrisKriterie";
            this.TbPrisKriterie.Size = new System.Drawing.Size(100, 22);
            this.TbPrisKriterie.TabIndex = 7;
            this.TbPrisKriterie.Visible = false;
            this.TbPrisKriterie.TextChanged += new System.EventHandler(this.TbPrisKriterie_TextChanged);
            // 
            // SolgteBoligerID
            // 
            this.SolgteBoligerID.Text = "Solgte boligers ID ->";
            this.SolgteBoligerID.Width = 145;
            // 
            // LblPris
            // 
            this.LblPris.AutoSize = true;
            this.LblPris.ForeColor = System.Drawing.Color.Black;
            this.LblPris.Location = new System.Drawing.Point(425, 325);
            this.LblPris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPris.Name = "LblPris";
            this.LblPris.Size = new System.Drawing.Size(287, 17);
            this.LblPris.TabIndex = 8;
            this.LblPris.Text = "Optional* Søg i solgte boliger fra denne pris:";
            this.LblPris.Visible = false;
            // 
            // DatoSøgning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblPris);
            this.Controls.Add(this.TbPrisKriterie);
            this.Controls.Add(this.LwResultater);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSlut);
            this.Controls.Add(this.dtpStart);
            this.Location = new System.Drawing.Point(350, 50);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DatoSøgning";
            this.Size = new System.Drawing.Size(907, 356);
            this.Load += new System.EventHandler(this.DatoSøgning_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpSlut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView LwResultater;
        private System.Windows.Forms.ColumnHeader Ejendomsmægler;
        private System.Windows.Forms.TextBox TbPrisKriterie;
        private System.Windows.Forms.ColumnHeader SolgteBoligerID;
        private System.Windows.Forms.Label LblPris;
    }
}
