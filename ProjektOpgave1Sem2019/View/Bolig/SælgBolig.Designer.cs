namespace ProjektOpgave1Sem2019.View
{
    partial class SælgBolig
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
            this.tbSælger = new System.Windows.Forms.TextBox();
            this.LblAdresse = new System.Windows.Forms.Label();
            this.dtpKøbsDato = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKøber = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSalgsPris = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKøbsPris = new System.Windows.Forms.TextBox();
            this.btnSolgt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sælger";
            // 
            // tbSælger
            // 
            this.tbSælger.Location = new System.Drawing.Point(6, 61);
            this.tbSælger.Name = "tbSælger";
            this.tbSælger.Size = new System.Drawing.Size(100, 20);
            this.tbSælger.TabIndex = 1;
            // 
            // LblAdresse
            // 
            this.LblAdresse.AutoSize = true;
            this.LblAdresse.ForeColor = System.Drawing.Color.Black;
            this.LblAdresse.Location = new System.Drawing.Point(228, 10);
            this.LblAdresse.Name = "LblAdresse";
            this.LblAdresse.Size = new System.Drawing.Size(70, 13);
            this.LblAdresse.TabIndex = 2;
            this.LblAdresse.Text = "Adresse label";
            // 
            // dtpKøbsDato
            // 
            this.dtpKøbsDato.Location = new System.Drawing.Point(6, 181);
            this.dtpKøbsDato.Name = "dtpKøbsDato";
            this.dtpKøbsDato.Size = new System.Drawing.Size(200, 20);
            this.dtpKøbsDato.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Købs dato";
            // 
            // cbKøber
            // 
            this.cbKøber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKøber.FormattingEnabled = true;
            this.cbKøber.Location = new System.Drawing.Point(6, 116);
            this.cbKøber.Name = "cbKøber";
            this.cbKøber.Size = new System.Drawing.Size(121, 21);
            this.cbKøber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Køber";
            // 
            // tbSalgsPris
            // 
            this.tbSalgsPris.Location = new System.Drawing.Point(6, 229);
            this.tbSalgsPris.Name = "tbSalgsPris";
            this.tbSalgsPris.Size = new System.Drawing.Size(100, 20);
            this.tbSalgsPris.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vejledende salgspris";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(142, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Faktiske Købspris";
            // 
            // tbKøbsPris
            // 
            this.tbKøbsPris.Location = new System.Drawing.Point(145, 229);
            this.tbKøbsPris.Name = "tbKøbsPris";
            this.tbKøbsPris.Size = new System.Drawing.Size(100, 20);
            this.tbKøbsPris.TabIndex = 10;
            // 
            // btnSolgt
            // 
            this.btnSolgt.Location = new System.Drawing.Point(514, 229);
            this.btnSolgt.Name = "btnSolgt";
            this.btnSolgt.Size = new System.Drawing.Size(75, 23);
            this.btnSolgt.TabIndex = 11;
            this.btnSolgt.Text = "Marker Solgt";
            this.btnSolgt.UseVisualStyleBackColor = true;
            this.btnSolgt.Click += new System.EventHandler(this.btnSolgt_Click);
            // 
            // SælgBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSolgt);
            this.Controls.Add(this.tbKøbsPris);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSalgsPris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbKøber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpKøbsDato);
            this.Controls.Add(this.LblAdresse);
            this.Controls.Add(this.tbSælger);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(350, 50);
            this.Name = "SælgBolig";
            this.Size = new System.Drawing.Size(680, 289);
            this.Load += new System.EventHandler(this.SælgBolig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSælger;
        private System.Windows.Forms.Label LblAdresse;
        private System.Windows.Forms.DateTimePicker dtpKøbsDato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKøber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSalgsPris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKøbsPris;
        private System.Windows.Forms.Button btnSolgt;
    }
}
