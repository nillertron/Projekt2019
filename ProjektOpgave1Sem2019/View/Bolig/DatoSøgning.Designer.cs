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
            this.SuspendLayout();
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(0, 33);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 1;
            // 
            // dtpSlut
            // 
            this.dtpSlut.Location = new System.Drawing.Point(0, 74);
            this.dtpSlut.Name = "dtpSlut";
            this.dtpSlut.Size = new System.Drawing.Size(200, 20);
            this.dtpSlut.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Slut Dato";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(6, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LwResultater
            // 
            this.LwResultater.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ejendomsmægler});
            this.LwResultater.HideSelection = false;
            this.LwResultater.Location = new System.Drawing.Point(259, 33);
            this.LwResultater.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LwResultater.Name = "LwResultater";
            this.LwResultater.Size = new System.Drawing.Size(394, 224);
            this.LwResultater.TabIndex = 6;
            this.LwResultater.UseCompatibleStateImageBehavior = false;
            this.LwResultater.View = System.Windows.Forms.View.Details;
            // 
            // Ejendomsmægler
            // 
            this.Ejendomsmægler.Text = "EjendomsmæglerID";
            this.Ejendomsmægler.Width = 142;
            // 
            // DatoSøgning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LwResultater);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSlut);
            this.Controls.Add(this.dtpStart);
            this.Location = new System.Drawing.Point(350, 50);
            this.Name = "DatoSøgning";
            this.Size = new System.Drawing.Size(680, 289);
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
    }
}
