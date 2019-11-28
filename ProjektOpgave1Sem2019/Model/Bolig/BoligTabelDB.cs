using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjektOpgave1Sem2019.Model;

namespace ProjektOpgave1Sem2019
{
        //Karl
    class BoligTabelDB
    {

        private static string GetAllQuery = "SELECT * FROM Bolig";

        private static string GetAllNotSoldQuery = " SELECT * FROM Bolig b  WHERE NOT EXISTS (SELECT * FROM SolgtBolig WHERE SolgtBolig.BoligID = b.ID)";



  

        public static List<Bolig> GetAll()
        {
            
            List<Bolig> boliger = new List<Bolig>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBHelper.Conn;
            cmd.CommandText = GetAllQuery; 
            try
            {
                DBHelper.Conn.Open();
            }
            catch 
            {
                //could not open database 
                System.Windows.Forms.MessageBox.Show("DB forbindelse kunne ikke åbnes");
            }
            using (DBHelper.Conn)
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Bolig bolig = GetBoligFromReader(reader);
                        boliger.Add(bolig);
                        
                    }
                }
            }
            

            return boliger;
        }

       

        public static List<Bolig> GetAllNotSold()
        {
            
            List<Bolig> boliger = new List<Bolig>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBHelper.Conn;
            cmd.CommandText = GetAllNotSoldQuery;

            try
            {
                DBHelper.Conn.Open();
            }
            catch 
            {
                //could not open database 
                System.Windows.Forms.MessageBox.Show("DB forbindelse kunne ikke åbnes");
            }
            using (DBHelper.Conn)
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Bolig bolig = GetBoligFromReader(reader);
                        boliger.Add(bolig);

                    }
                }
            }

            
            return boliger;


        }


        private static Bolig GetBoligFromReader(SqlDataReader reader)
        {

            int iD = Convert.ToInt32(reader["ID"]);
            string adresse = Convert.ToString(reader["Adresse"]);
            double pris = Convert.ToDouble(reader["Pris"]);
            int sælgerId = Convert.ToInt32(reader["SælgerID"]);
            int kvm = Convert.ToInt32(reader["Kvm"]);
            DateTime oprettelsesDato = Convert.ToDateTime(reader["oprettelsesDato"]);
            int EjendomsmæglerId = Convert.ToInt32(reader["EjendomsmæglerID"]);
            int postNr = Convert.ToInt32(reader["PostNr"]);

            Bolig bolig = new Bolig(iD, adresse, pris, sælgerId, kvm, oprettelsesDato, EjendomsmæglerId, postNr);

            return bolig;
        }


        // //public static bool Create(Bolig b)
        // {

        // }
        // //public static bool Update(Bolig b)
        // {

        // }
        // //public static bool Delete(Bolig b)
        // {

        // }

    }
}
