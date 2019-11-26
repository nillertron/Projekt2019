using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjektOpgave1Sem2019.Model
{
    class EjendomsmæglerTabelDB
    {
        public static List<Ejendomsmægler> GetAll() //Metode der skal hookes up til viewmodel
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBHelper.Conn;
            cmd.CommandText = "SELECT * FROM Ejendomsmægler";

            List<Ejendomsmægler> returnList = new List<Ejendomsmægler>();

            DBHelper.Conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {

                while (reader.Read())
                {
                    returnList.Add(new Ejendomsmægler(reader.GetInt32(0), //Hard coded, skal ændres hvis databasen ændres
                                                        reader.GetString(1),
                                                        reader.GetString(2),
                                                        reader.GetInt32(3).ToString(),
                                                        reader.GetString(5),
                                                        reader.GetDateTime(4)));
                }
            }
            DBHelper.Conn.Close();
            return returnList;
        }

        public static bool Create(Ejendomsmægler e) //Metode der skal hookes op til Viewmodel
        {
            bool wasSuccess;

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = DBHelper.Conn;
                string commandString = "INSERT INTO Ejendomsmægler VALUES(";
                commandString += "@Fornavn, ";
                commandString += "@Efternavn, ";
                commandString += "@Tlf ,";
                commandString += "@Fødselsdag, ";
                commandString += "@KontoNr)"; //End of commandstring
                cmd.CommandText = commandString;
                cmd.Parameters.Add("@Fornavn", System.Data.SqlDbType.NVarChar).Value = e.Navn;
                cmd.Parameters.Add("@Efternavn", System.Data.SqlDbType.NVarChar).Value = e.Efternavn;
                cmd.Parameters.Add("@Tlf", System.Data.SqlDbType.Int).Value = Convert.ToInt32(e.TelefonNr); //Telefonnummer i klasse er string, database er int, skal måske nok ændres
                cmd.Parameters.Add("@Fødselsdag", System.Data.SqlDbType.DateTime).Value = e.Fødseldato;
                cmd.Parameters.Add("@KontoNr", System.Data.SqlDbType.NVarChar).Value = e.KontoNr;

                int id = 0;
                using (SqlCommand cmd2 = new SqlCommand())
                {
                    cmd2.Connection = DBHelper.Conn;
                    cmd2.CommandText = "SELECT MAX(ID) + 1 FROM Ejendomsmægler";

                    DBHelper.Conn.Open();
                    using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        reader.Read();
                        id = reader.GetInt32(0);
                    }
                    DBHelper.Conn.Close();
                }
                e.Id = id;

                    try
                    {
                        DBHelper.Conn.Open();
                        cmd.ExecuteNonQuery();
                        DBHelper.Conn.Close();
                        wasSuccess = true; //Hvis NonQuery lykkes, er det en success, kommer aldrig her hvis Exception bliver thrown
                    }
                    catch (SqlException)
                    {
                        wasSuccess = false; //Noget gik galt
                    }
                
            }
            return wasSuccess;
        }
        public static bool Update(Ejendomsmægler e) //Metode der skal hookes op til Viewmodel
        {
            bool wasSuccess;

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = DBHelper.Conn;
                string commandString = "UPDATE Ejendomsmægler SET Fornavn = @Fornavn, Efternavn = @Efternavn, Tlf = @Tlf, Fødselsdato = @Fødselsdag, KontoNr = @KontoNr WHERE ID = @ID"; //End of commandstring
                cmd.CommandText = commandString;
                cmd.Parameters.Add("@Fornavn", System.Data.SqlDbType.NVarChar).Value = e.Navn;
                cmd.Parameters.Add("@Efternavn", System.Data.SqlDbType.NVarChar).Value = e.Efternavn;
                cmd.Parameters.Add("@Tlf", System.Data.SqlDbType.Int).Value = Convert.ToInt32(e.TelefonNr); //Telefonnummer i klasse er string, database er int, skal måske nok ændres
                cmd.Parameters.Add("@Fødselsdag", System.Data.SqlDbType.DateTime).Value = e.Fødseldato;
                cmd.Parameters.Add("@KontoNr", System.Data.SqlDbType.NVarChar).Value = e.KontoNr;

                cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = e.Id;

                try
                {
                    DBHelper.Conn.Open();
                    cmd.ExecuteNonQuery();
                    DBHelper.Conn.Close();
                    wasSuccess = true; //Hvis NonQuery lykkes, er det en success, kommer aldrig her hvis Exception bliver thrown
                }
                catch (SqlException q)
                {
                    
                    wasSuccess = false; //Noget gik galt
                }

            }
           
            return wasSuccess;
        }

        public static bool Delete(Ejendomsmægler e)
        {
            bool wasSuccessful;

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = DBHelper.Conn;
                string commandString = "DELETE Ejendomsmægler ";
                commandString += "WHERE ID = @ID";

                cmd.CommandText = commandString;
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = e.Id;

                try
                {
                    DBHelper.Conn.Open();
                    cmd.ExecuteNonQuery();
                    DBHelper.Conn.Close();
                    wasSuccessful = true;
                }
                catch(SqlException)
                {
                    wasSuccessful = false;
                }
                
            }
            return wasSuccessful;
        }


        //prøvede lige at lave et par metoder til at læse og oprette fra DB
        //Husk at ændre db brugeren til at være fra DK for at kunne bruge datetime fra c#!
        //Security -> logins -> bruger, højreklik -> properties -> nederst ændre default language til dansk
        public static void OpretEjendomsmægler(Ejendomsmægler data)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();


                    using (SqlCommand command = new SqlCommand("Insert into Ejendomsmægler (Fornavn, Efternavn, Tlf, Fødselsdato, KontoNr) values ('" + data.Navn + "', '" + data.Efternavn + "','" + data.TelefonNr + "', '"+ data.Fødseldato + "', '"+data.KontoNr+"')"))
                    {
                        command.Connection = conn;
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Done!");
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static List<Ejendomsmægler> GetAllEjendomsmæglere()
        {
            var liste = new List<Ejendomsmægler>();
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();
                    SqlDataReader dataReader;
                    using (SqlCommand command = new SqlCommand("Select Id, Fornavn, Efternavn, Tlf, KontoNr, Fødselsdato From ejendomsmægler", conn))
                    {
                        dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            liste.Add(new Ejendomsmægler(Convert.ToInt32(dataReader.GetValue(0)), dataReader.GetValue(1).ToString(), dataReader.GetValue(2).ToString(), dataReader.GetValue(3).ToString(), dataReader.GetValue(4).ToString(), Convert.ToDateTime(dataReader.GetValue(5))));
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
    }
}
