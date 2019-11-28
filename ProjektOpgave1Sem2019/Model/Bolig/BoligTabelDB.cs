﻿using System;
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


            try
            {
                DBHelper.Conn.Open();
            }
            catch 
            {
                //could not open database 
                System.Windows.Forms.MessageBox.Show("DB forbindelse kunne ikke åbnes");
            }
            
            using (SqlCommand cmd = new SqlCommand())
            {
            cmd.Connection = DBHelper.Conn;
            cmd.CommandText = GetAllQuery; 

            
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Bolig bolig = GetBoligFromReader(reader);
                        boliger.Add(bolig);
                        
                    }
                }
            }
         
            

            DBHelper.Conn.Close();
            return boliger;
        }

       

        public static List<Bolig> GetAllNotSold()
        {
            
            List<Bolig> boliger = new List<Bolig>();


            try
            {
                DBHelper.Conn.Open();
            }
            catch 
            {
                //could not open database 
                System.Windows.Forms.MessageBox.Show("DB forbindelse kunne ikke åbnes");
            }

            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.Connection = DBHelper.Conn;
                cmd.CommandText = GetAllNotSoldQuery;


            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Bolig bolig = GetBoligFromReader(reader);
                    boliger.Add(bolig);

                }
            }
        }


            
               
            
            DBHelper.Conn.Close(); 
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




         public static Bolig Create(Bolig b)
         {

            int nyBoligId = 0;
          

            try
            {
                DBHelper.Conn.Open();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("DB forbindelse kunne ikke åbnes");
            }
         

            
                using (SqlCommand cmd = new SqlCommand()) 
                {
                string query = " INSERT INTO Bolig( Adresse, Pris, SælgerID, Kvm, OprettelsesDato, EjendomsmæglerID, PostNr) ";
                query += $" VALUES ( '{b.Adresse}', {b.Pris}, {b.SælgerID}, {b.Kvm}, @OprettelsesDato, {b.EjendomsmæglerID}, {b.PostNr} )";
                //{b.OprettelsesDato.ToOADate()}
                cmd.Connection = DBHelper.Conn;
                cmd.CommandText = query;
                //Parameter fungerer med SqlDateTime
                cmd.Parameters.Add("@OprettelsesDato", System.Data.SqlDbType.DateTime).Value = b.OprettelsesDato;



                    try
                    {
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception e)
                    {
                        System.Diagnostics.Debug.WriteLine(e);
                        System.Windows.Forms.MessageBox.Show("Database acceptered ikke værdier, se debugger for detaljer");
                    }
                    
                }
                // get the id (autoincremented from DB):
               
                using (SqlCommand getIdCmd = new SqlCommand())
                {
                    string getIdQuery = "SELECT MAX(ID) AS ID FROM Bolig";
                    getIdCmd.Connection = DBHelper.Conn;
                    getIdCmd.CommandText = getIdQuery;
                    using (SqlDataReader reader = getIdCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nyBoligId = Convert.ToInt32(reader["ID"]); 
                        }
                    }
            }



           Bolig nyBolig = new Bolig(nyBoligId, b.Adresse, b.Pris, b.SælgerID, b.Kvm, b.OprettelsesDato, b.EjendomsmæglerID, b.PostNr);


            DBHelper.Conn.Close(); 
            return nyBolig;
         }



     




        public static bool Update(Bolig b)
        {
            bool success = false;


            try
            {
                DBHelper.Conn.Open();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("DB forbindelse kunne ikke åbnes");
            }



            using(SqlCommand cmd = new SqlCommand())
            {
            string query = " UPDATE Bolig ";
            query += $" SET Adresse = '{b.Adresse}', " +
                $" Pris = {b.Pris}, " +
                $" SælgerID = {b.SælgerID}, " +
                $" Kvm = {b.Kvm}, " +
                $" OprettelsesDato = {b.OprettelsesDato.ToOADate()}, " +
                $" EjendomsmæglerID = {b.EjendomsmæglerID}, " +
                $" PostNr = {b.PostNr} " +
                $" WHERE ID = {b.ID}";
            cmd.CommandText = query;
            cmd.Connection = DBHelper.Conn;


                try
                {
                    cmd.ExecuteNonQuery();
                    success = true;
                }
                catch (Exception e)
                {

                    System.Diagnostics.Debug.WriteLine(e);
                    System.Windows.Forms.MessageBox.Show("Database acceptered ikke værdier, se debugger for detaljer");
                }
            }


            DBHelper.Conn.Close();
            return success;
        }





        public static bool Delete(Bolig b)
        {
            bool success = false;

            try
            {
                DBHelper.Conn.Open();

            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("DB forbindelse kunne ikke åbnes");

            } 


            using (SqlCommand cmd = new SqlCommand())
            {
                string query = $" DELETE FROM Bolig " +
                    $"WHERE ID = {b.ID}";

                cmd.Connection = DBHelper.Conn;
                cmd.CommandText = query;
                try
                {
                    cmd.ExecuteNonQuery();
                    success = true;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    System.Windows.Forms.MessageBox.Show("Database acceptered ikke værdier, se debugger for detaljer");
                }
   
            }

            DBHelper.Conn.Close();
            return success;

        }








        public static bool CreateSolgtBolig(SolgtBolig b)
       {
            bool success = false;

            try
            {
            DBHelper.Conn.Open();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("DB did not open");
            }


            using(SqlCommand cmd = new SqlCommand())
            {
                string query = $" INSERT INTO SolgtBolig " +
                    $" (BoligID, KøberID, Købspris, KøbsDato) " +
                    $" VALUES " +
                    $" ({b.ID}, {b.KøberID}, {b.KøbsPris}, {b.KøbsDato.ToOADate()}) ";
                cmd.CommandText = query;
                cmd.Connection = DBHelper.Conn;
                
                try
                {
                cmd.ExecuteNonQuery();
                    success = true; 
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("values not accepted in DB");
                }

            }




                DBHelper.Conn.Close();
                return success;
        }

    }
}
