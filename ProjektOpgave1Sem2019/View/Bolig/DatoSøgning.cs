﻿using System;
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


        //karl 
        private void FyldListView(bool medPrisKriterie)
        {
            
            LwResultater.Items.Clear();


            //get array 
            SolgtBolig[,] arr = ViewModel.KonverterTilArrayKarl();
    

            //set listView  row mængde = max solgte boliger 
            int columnWidth = 50;
            while (LwResultater.Columns.Count < arr.GetLength(1) + 1)
                LwResultater.Columns.Add("", columnWidth);



            if (medPrisKriterie)
            {
                if (TbPrisKriterie.Text != "")
                {
                    if (Double.TryParse(TbPrisKriterie.Text, out double fraPris))
                    {
                        //add elements that correspond to search terms
                        for (int i = 0; i < arr.GetLength(0); i++) //foreach ejendomsmægler
                        {
                            ListViewItem item = new ListViewItem(arr[i, 0].EjendomsmæglerID.ToString());

                            for (int j = 1; j < arr.GetLength(1); j++)//foreach solgtbolig
                                if (arr[i, j] != null && arr[i, j].KøbsPris >= fraPris)
                                    item.SubItems.Add(arr[i, j].ID.ToString());

                            LwResultater.Items.Add(item);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ugyldigt søgekriterie");
                        TbPrisKriterie.Text = TbPrisKriterie.Text.Substring(0, TbPrisKriterie.Text.Length - 1);
                    }
                }
                else//no input
                    FyldListView(false);
            }






            else//uden pris kriterie
            {

                
            //add all elements to list view
            for (int i = 0; i < arr.GetLength(0); i++)//foreach ejendomsmælger
            {
                ListViewItem item = new ListViewItem(arr[i,0].EjendomsmæglerID.ToString());

                for (int j = 1; j < arr.GetLength(1); j++)//foreach solgtbolig
                    if (arr[i, j] != null)
                            item.SubItems.Add(arr[i,j].ID.ToString());

                LwResultater.Items.Add(item);

            }
            }

        }
        


        

        
  
  //karl slut          


        private void button1_Click(object sender, EventArgs e)
        {
            ViewModel.SorterEfter2datoer(dtpStart.Value, dtpSlut.Value);
            FyldListView(false);

            TbPrisKriterie.Show();
            LblPris.Show();

        }

        private void TbPrisKriterie_TextChanged(object sender, EventArgs e)
        {
            FyldListView(true);
        }
    }
}
