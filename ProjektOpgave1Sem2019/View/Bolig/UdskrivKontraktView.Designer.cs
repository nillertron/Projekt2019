namespace ProjektOpgave1Sem2019
{
    partial class UdskrivKontraktView
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
            this.lwSolgteBoliger = new System.Windows.Forms.ListView();
            this.btnUdskriv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSti = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.Adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sælger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Køber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lwSolgteBoliger
            // 
            this.lwSolgteBoliger.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Adresse,
            this.Sælger,
            this.Køber});
            this.lwSolgteBoliger.Location = new System.Drawing.Point(0, 40);
            this.lwSolgteBoliger.MultiSelect = false;
            this.lwSolgteBoliger.Name = "lwSolgteBoliger";
            this.lwSolgteBoliger.Size = new System.Drawing.Size(680, 142);
            this.lwSolgteBoliger.TabIndex = 0;
            this.lwSolgteBoliger.UseCompatibleStateImageBehavior = false;
            this.lwSolgteBoliger.View = System.Windows.Forms.View.Details;
            this.lwSolgteBoliger.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnUdskriv
            // 
            this.btnUdskriv.ForeColor = System.Drawing.Color.Black;
            this.btnUdskriv.Location = new System.Drawing.Point(602, 263);
            this.btnUdskriv.Name = "btnUdskriv";
            this.btnUdskriv.Size = new System.Drawing.Size(75, 23);
            this.btnUdskriv.TabIndex = 1;
            this.btnUdskriv.Text = "Udskriv";
            this.btnUdskriv.UseVisualStyleBackColor = true;
            this.btnUdskriv.Click += new System.EventHandler(this.btnUdskriv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vælg sti til gem";
            // 
            // tbSti
            // 
            this.tbSti.Location = new System.Drawing.Point(6, 201);
            this.tbSti.Name = "tbSti";
            this.tbSti.Size = new System.Drawing.Size(271, 20);
            this.tbSti.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.ForeColor = System.Drawing.Color.Black;
            this.btnBrowse.Location = new System.Drawing.Point(283, 198);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Adresse
            // 
            this.Adresse.Text = "Adresse";
            this.Adresse.Width = 430;
            // 
            // Sælger
            // 
            this.Sælger.Text = "Sælger";
            this.Sælger.Width = 75;
            // 
            // Køber
            // 
            this.Køber.Text = "Køber";
            // 
            // UdskrivKontraktView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbSti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUdskriv);
            this.Controls.Add(this.lwSolgteBoliger);
            this.Location = new System.Drawing.Point(350, 50);
            this.Name = "UdskrivKontraktView";
            this.Size = new System.Drawing.Size(680, 289);
            this.Load += new System.EventHandler(this.UdskrivKontraktView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lwSolgteBoliger;
        private System.Windows.Forms.Button btnUdskriv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSti;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ColumnHeader Adresse;
        private System.Windows.Forms.ColumnHeader Sælger;
        private System.Windows.Forms.ColumnHeader Køber;
    }
}
