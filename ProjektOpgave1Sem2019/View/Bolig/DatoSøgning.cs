using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektOpgave1Sem2019.View_Model;

namespace ProjektOpgave1Sem2019
{
    public partial class DatoSøgning : UserControl
    {//Nichlas
        DatoSøgningViewModel ViewModel;
        public DatoSøgning(List<Bolig> liste)
        {
            InitializeComponent();
            ViewModel = new DatoSøgningViewModel(liste);



        }

        private void DatoSøgning_Load(object sender, EventArgs e)
        {

        }

        private void fyldboks()
        {
            //niclas udkommenteret
            // string[,] array = ViewModel.KonverterTilArray();


            //for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            //    {
            //    for(int x = 0; x < array.GetUpperBound(1) + 1; x++)
            //    rtbContent.AppendText(array[i, x].PadLeft(10));
            //    rtbContent.AppendText("\r\n");

            //}


            //karl

            LwResultater.Items.Clear();

            string[,] arr = ViewModel.KonverterTilArrayKarl();

            //set listView  row længde
            if(LwResultater.Columns.Count < 2)
            for(int i = 0; i < arr.GetLength(1) - 1; i++)
            {
                if(i == 0)
                    LwResultater.Columns.Add("", 120);
                else
                    LwResultater.Columns.Add("", 50);
            }


           
            //add elements to listview
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                ListViewItem item = new ListViewItem(arr[i,0]);

                for (int j = 1; j < arr.GetLength(1); j++)
                    if (arr[i, j] != null)
                        item.SubItems.Add(arr[i,j]);

                LwResultater.Items.Add(item); 
            }

        }
  
  //karl slut          


        private void button1_Click(object sender, EventArgs e)
        {
            ViewModel.SorterEfter2datoer(dtpStart.Value, dtpSlut.Value);
            fyldboks();
           
        }
    }
}
