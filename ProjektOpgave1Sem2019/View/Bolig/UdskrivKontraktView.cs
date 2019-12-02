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

namespace ProjektOpgave1Sem2019
{
    //Nichlas
    public partial class UdskrivKontraktView : UserControl
    {
        UdskrivKontraktViewModel ViewModel;
        FolderBrowserDialog openFileDialog1;
        public UdskrivKontraktView()
        {
            InitializeComponent();
            ViewModel = new UdskrivKontraktViewModel();
            FillListView();


        }
        private void FillListView()
        {

            lwSolgteBoliger.Items.AddRange(ViewModel.GetListViewItems().ToArray());
            lwSolgteBoliger.FullRowSelect = true;


        }

        private void UdskrivKontraktView_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new FolderBrowserDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                tbSti.Text = openFileDialog1.SelectedPath;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUdskriv_Click(object sender, EventArgs e)
        {
            if (tbSti.Text != "" && tbSti != null && lwSolgteBoliger.SelectedItems != null)
            {
                var path = tbSti.Text;
                var bolig = (int)lwSolgteBoliger.FocusedItem.Tag;
                try
                {
                    ViewModel.UdskrivTilFil(bolig, path);
                }
                catch (IOException ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            else
                MessageBox.Show("Fejl, vælg sag og sti");

        }
    }
}
