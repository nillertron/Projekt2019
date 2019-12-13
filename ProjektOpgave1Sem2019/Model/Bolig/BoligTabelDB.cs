using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjektOpgave1Sem2019.Model;
using System.Windows.Forms;

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

            
          

            try
            {
                DBHelper.Conn.Open();
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("Databasen kunne ikke åbnes"); 
            }

           
            
                using (SqlCommand cmd = new SqlCommand()) 
                {
                string query = " INSERT INTO Bolig( Adresse, Pris, SælgerID, Kvm, OprettelsesDato, EjendomsmæglerID, PostNr) ";
                query += $" VALUES ( @Adresse, @Pris, @SælgerID, @Kvm, @OprettelsesDato, @EjendomsmæglerID, @PostNr )";
               
                cmd.Connection = DBHelper.Conn;
                cmd.CommandText = query;


                AddValueToParametersFromBolig(b, cmd);



                try
                    {
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception e)
                    {
                    System.Diagnostics.Debug.WriteLine(e);
                    }
                    
                }

            // get the id (autoincremented from DB):
            int nyBoligId = DBHelper.GetNewestIdFromTabel("Bolig", DBHelper.Conn);
            
           Bolig nyBolig = new Bolig(nyBoligId, b.Adresse, b.Pris, b.SælgerID, b.Kvm, b.OprettelsesDato, b.EjendomsmæglerID, b.PostNr);

            b = nyBolig;//skal vi bruge denne istedet for at returne en Bolig?

            DBHelper.Conn.Close(); 
            return nyBolig;
         }




        private static void AddValueToParametersFromBolig(Bolig boligWithValues, SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Adresse", boligWithValues.Adresse);
            cmd.Parameters.AddWithValue("@Pris", boligWithValues.Pris);
            cmd.Parameters.AddWithValue("@SælgerID", boligWithValues.SælgerID);
            cmd.Parameters.AddWithValue("@Kvm", boligWithValues.Kvm);
            cmd.Parameters.AddWithValue("@OprettelsesDato", boligWithValues.OprettelsesDato);
            cmd.Parameters.AddWithValue("@EjendomsmæglerID", boligWithValues.EjendomsmæglerID);
            cmd.Parameters.AddWithValue("@PostNr", boligWithValues.PostNr);
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
            query += $" SET Adresse = @Adresse, " +
                $" Pris = @Pris, " +
                $" SælgerID = @SælgerID, " +
                $" Kvm = @Kvm, " +
                $" OprettelsesDato = @OprettelsesDato, " +
                $" EjendomsmæglerID = @EjendomsmæglerID, " +
                $" PostNr = @PostNr " +
                $" WHERE ID = {b.ID}";//ingen parameters på id, da den aldrig opdateres og er intern sat
            cmd.CommandText = query;
            cmd.Connection = DBHelper.Conn;

                AddValueToParametersFromBolig(b, cmd);
        
                
                try
                {
                    cmd.ExecuteNonQuery();
                    success = true;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
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
                System.Diagnostics.Debug.WriteLine("Database blev ikke åbnet");
            }


            using(SqlCommand cmd = new SqlCommand())
            {
                //string query = $" INSERT INTO SolgtBolig " +
                //    $" (BoligID, KøberID, Købspris, KøbsDato) " +
                //    $" VALUES " +
                //    $" ({b.ID}, {b.KøberID}, @Købspris, '{b.OprettelsesDato}') ";

                string query = $" INSERT INTO SolgtBolig " +
                    $" (BoligID, KøberID, Købspris, KøbsDato) " +
                    $" VALUES " +
                    $" ({b.ID}, {b.KøberID}, @Købspris, @Dato) ";

                cmd.CommandText = query;
                cmd.Connection = DBHelper.Conn;

           
                cmd.Parameters.AddWithValue("@Købspris", b.KøbsPris);
                cmd.Parameters.Add("@Dato", System.Data.SqlDbType.DateTime).Value = b.KøbsDato;
               

                try
                {
                cmd.ExecuteNonQuery();
                    success = true; 
                }
                catch
                {
                    System.Diagnostics.Debug.WriteLine("values not accepted in DB");
                }

            }
            
            



                DBHelper.Conn.Close();
                return success;
        }













        #region Nichlas
        //Har lige brug for at lave en metode til at tjekke om en bolig er solgt, du er velkommen til at lave din egen og slette denne :)
        //niklas
        public static bool TjekBoligSolgt(Bolig b)
        {
            var ErSolgt = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();
                    SqlDataReader dataReader;
                    using (SqlCommand command = new SqlCommand("select * from bolig inner join solgtbolig on solgtbolig.boligid = bolig.id where id = "+b.ID, conn))
                    {
                        dataReader = command.ExecuteReader();
                        if (dataReader.HasRows)
                            ErSolgt = true;
 
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return ErSolgt;
        }
        //og en mere til at gemme sælger info når der skal udskrives til fil
        //niklas
        public static List<Bolig> GetAllBoligMedSælger()
        {
            var liste = new List<Bolig>();
             try
                {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();
                    SqlDataReader dataReader;
                    using (SqlCommand command = new SqlCommand("select * from Bolig inner join Sælger on sælger.ID = bolig.SælgerID", conn))
                    {
                        Sælger sælger = new Sælger();
                        dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        liste.Add(new Bolig(dataReader.GetInt32(0), dataReader.GetString(1), Convert.ToDouble(dataReader.GetValue(2)), dataReader.GetInt32(3), dataReader.GetInt32(4), dataReader.GetDateTime(5), dataReader.GetInt32(6), dataReader.GetInt32(7), sælger = new Sælger(dataReader.GetInt32(8), dataReader.GetString(9), dataReader.GetString(10), dataReader.GetString(11), dataReader.GetString(12), dataReader.GetInt32(13), dataReader.GetString(14))));
                        



                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return liste;
        }
        public static List<SolgtBolig> GetSolgtDetaljerFraListe(List<SolgtBolig> liste)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {

                    liste.ForEach(o =>
                    {
                        conn.Open();
                        SqlDataReader dataReader;
                        using (SqlCommand command = new SqlCommand("select KøberID, Købspris, KøbsDato from SolgtBolig where BoligID =" +o.ID, conn))
                        {
                            Sælger sælger = new Sælger();
                            dataReader = command.ExecuteReader();
                            while (dataReader.Read())
                            {
                                o.SetValues(dataReader.GetInt32(0), Convert.ToDouble(dataReader.GetValue(1)), dataReader.GetDateTime(2));

                            }

                            conn.Close();


                        }
                    });

                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return liste;
        }
        public static List<SolgtBolig> GetAllSolgteBoliger()
        {
            var liste = new List<SolgtBolig>();

            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {


                        conn.Open();
                        SqlDataReader dataReader;
                        using (SqlCommand command = new SqlCommand("select Id, adresse, pris, sælgerid, kvm, OprettelsesDato,EjendomsmæglerID,PostNr,KøberID,Købspris,KøbsDato from bolig inner join solgtbolig on bolig.ID = SolgtBolig.BoligID", conn))
                        {
                            Sælger sælger = new Sælger();
                            dataReader = command.ExecuteReader();
                            while (dataReader.Read())
                            {
                            liste.Add(new SolgtBolig(dataReader.GetInt32(0), dataReader.GetString(1), Convert.ToDouble(dataReader.GetValue(2)), dataReader.GetInt32(3), dataReader.GetInt32(4), dataReader.GetDateTime(5), dataReader.GetInt32(6), dataReader.GetInt32(7), dataReader.GetInt32(8), Convert.ToDouble(dataReader.GetValue(9)), dataReader.GetDateTime(10)));
                            }



                        }
                   

                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return liste;
        }
        #endregion
    }
}
