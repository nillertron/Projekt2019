using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProjektOpgave1Sem2019.Model;

namespace ProjektOpgave1Sem2019.View.Bolig
{
    public partial class BoligSøgning : UserControl
    {
        //Nichlas
        BoligViewModel ViewModel;
        Stream myStream;
        SaveFileDialog saveFileDialog2 = new SaveFileDialog();
        private bool mode;
        public BoligSøgning(BoligViewModel ViewModel, bool mode)
        {
            InitializeComponent();
            this.ViewModel = ViewModel;

            if (mode)
            {
                cbPostNr.DataSource = ViewModel.postNumre;
                cbPostNr.DisplayMember = "PostNummer";
                label1.Show();
                cbPostNr.Show();
                this.mode = mode;
            }
            else
            {
                label1.Hide();
                cbPostNr.Hide();
                this.mode = mode;
            }

            saveFileDialog2.FileOk += (o, e) => tbSti.Text = saveFileDialog2.FileName;
            cbPostNr.SelectedIndexChanged += (o, e) => { var by = cbPostNr.SelectedItem as PostNumre; lblBy.Text = by.Distrikt; };
        }

        private void BoligSøgning_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {


            saveFileDialog2.Filter = "txt files (*.txt)|";
            saveFileDialog2.FilterIndex = 2;
            saveFileDialog2.RestoreDirectory = true;

            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog2.OpenFile()) != null)
                {
                    myStream.Close();
                }
            }
        }

        private void btnUdskriv_Click(object sender, EventArgs e)
        {
            var path = @"" + tbSti.Text;
            if (mode)
            {
                var postnummer = cbPostNr.SelectedItem as PostNumre;
                ViewModel.UdskrivBoligerFraByTilTxtFil(postnummer.PostNummer, path);

            }
            else
            {
                ViewModel.UdskrivBoligerTilTxtFil(path);
            }

        }
    }
}
