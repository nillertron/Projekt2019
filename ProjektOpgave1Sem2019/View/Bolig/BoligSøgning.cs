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
        BoligViewModel ViewModel;
        Stream myStream;
        SaveFileDialog saveFileDialog2 = new SaveFileDialog();
        private bool mode;
        public BoligSøgning(BoligViewModel ViewModel)
        {
            InitializeComponent();
            this.ViewModel = ViewModel;
            cbPostNr.DataSource = ViewModel.postNumre;
            cbPostNr.DisplayMember = "PostNummer";
            saveFileDialog2.FileOk += (o, e) => tbSti.Text = saveFileDialog2.FileName;
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
            var postnummer = cbPostNr.SelectedItem as PostNumre;
            var path = @"" + tbSti.Text;
            ViewModel.UdskrivBoligerFraByTilTxtFil(postnummer.PostNummer, path);
        }
    }
}
