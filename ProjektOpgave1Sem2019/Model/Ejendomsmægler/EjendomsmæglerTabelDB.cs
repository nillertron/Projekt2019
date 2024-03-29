﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjektOpgave1Sem2019.Model
{
    //Martin start
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
                                                        reader.GetString(3),
                                                        reader.GetDateTime(4),
                                                        reader.GetInt32(5),
                                                        reader.GetString(6),
                                                        reader.GetString(7)));
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
                commandString += "@Tlf,";
                commandString += "@Fødselsdag, ";
                commandString += "@PostNr, ";
                commandString += "@KontoNr, ";
                commandString += "@Adresse)";//End of commandstring
                cmd.CommandText = commandString;
                cmd.Parameters.Add("@Fornavn", System.Data.SqlDbType.NVarChar).Value = e.Navn;
                cmd.Parameters.Add("@Efternavn", System.Data.SqlDbType.NVarChar).Value = e.Efternavn;
                cmd.Parameters.Add("@Tlf", System.Data.SqlDbType.NVarChar).Value = e.TelefonNr; //Telefonnummer i klasse er string, database er int, skal måske nok ændres
                cmd.Parameters.Add("@Fødselsdag", System.Data.SqlDbType.DateTime).Value = e.Fødseldato;
                cmd.Parameters.Add("@PostNr", System.Data.SqlDbType.Int).Value = e.PostNr;
                cmd.Parameters.Add("@KontoNr", System.Data.SqlDbType.NVarChar).Value = e.KontoNr;
                cmd.Parameters.Add("@Adresse", System.Data.SqlDbType.NVarChar).Value = e.Addresse;

                int id = 0;
                using (SqlCommand cmd2 = new SqlCommand())
                {
                    cmd2.Connection = DBHelper.Conn;
                    cmd2.CommandText = "SELECT ISNULL(MAX(ID) + 1,  1) FROM Ejendomsmægler";

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

                    wasSuccess = true; //Hvis NonQuery lykkes, er det en success, kommer aldrig her hvis Exception bliver thrown
                }
                catch (SqlException ee)
                {
                    wasSuccess = false; //Noget gik galt
                    MessageBox.Show(ee.Message);
                }
                finally
                {
                    DBHelper.Conn.Close();
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
                string commandString = "UPDATE Ejendomsmægler SET Fornavn = @Fornavn, Efternavn = @Efternavn, Tlf = @Tlf, Fødselsdato = @Fødselsdag, PostNr = @PostNr, KontoNr = @KontoNr, Adresse = @Adresse WHERE ID = @ID"; //End of commandstring
                cmd.CommandText = commandString;
                cmd.Parameters.Add("@Fornavn", System.Data.SqlDbType.NVarChar).Value = e.Navn;
                cmd.Parameters.Add("@Efternavn", System.Data.SqlDbType.NVarChar).Value = e.Efternavn;
                cmd.Parameters.Add("@Tlf", System.Data.SqlDbType.NVarChar).Value = e.TelefonNr;
                cmd.Parameters.Add("@Fødselsdag", System.Data.SqlDbType.DateTime).Value = e.Fødseldato;
                cmd.Parameters.Add("@KontoNr", System.Data.SqlDbType.NVarChar).Value = e.KontoNr;
                cmd.Parameters.Add("@PostNr", System.Data.SqlDbType.Int).Value = e.PostNr;
                cmd.Parameters.Add("@Adresse", System.Data.SqlDbType.NVarChar).Value = e.Addresse;

                cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = e.Id;

                try
                {
                    DBHelper.Conn.Open();
                    cmd.ExecuteNonQuery();
                    wasSuccess = true; //Hvis NonQuery lykkes, er det en success, kommer aldrig her hvis Exception bliver thrown
                }
                catch (SqlException q)
                {
                    
                    wasSuccess = false; //Noget gik galt
                    MessageBox.Show(q.Message);
                }
                finally
                {
                    DBHelper.Conn.Close();
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
                    wasSuccessful = true;
                }
                catch(SqlException ee)
                {
                    wasSuccessful = false;
                    MessageBox.Show(ee.Message);
                }
                finally
                {
                    DBHelper.Conn.Close();
                }
                
            }
            return wasSuccessful;
        }

        public static Ejendomsmægler GetEjendomsmægler(int id) //Find enkelt ejendomsmægler -Martin
        {       //Bruges i BoligViewModel
            string cmdString = "SELECT * FROM Ejendomsmægler WHERE ID = @ID";

            Ejendomsmægler e;

            using (SqlCommand cmd = new SqlCommand(cmdString, DBHelper.Conn))
            {
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = id;

                DBHelper.Conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();

                    e = new Ejendomsmægler(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                reader.GetString(3), reader.GetDateTime(4), reader.GetInt32(5),
                                reader.GetString(6), reader.GetString(7));
                }
                DBHelper.Conn.Close();
            }

            return e;
        }

        //Martin slut


        //prøvede lige at lave et par metoder til at læse og oprette fra DB
        //Husk at ændre db brugeren til at være fra DK for at kunne bruge datetime fra c#!
        //Security -> logins -> bruger, højreklik -> properties -> nederst ændre default language til dansk
        //public static void OpretEjendomsmægler(Ejendomsmægler data)
        //{
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
        //        {
        //            conn.Open();


        //            using (SqlCommand command = new SqlCommand("Insert into Ejendomsmægler (Fornavn, Efternavn, Tlf, Fødselsdato, KontoNr) values ('" + data.Navn + "', '" + data.Efternavn + "','" + data.TelefonNr + "', '"+ data.Fødseldato + "', '"+data.KontoNr+"')"))
        //            {
        //                command.Connection = conn;
        //                command.ExecuteNonQuery();
        //            }

        //            MessageBox.Show("Done!");
        //        }
        //    }
        //    catch(SqlException e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //}

        //public static List<PostNumre> GetAllPostnumre()
        //{
        //    var liste = new List<PostNumre>();
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
        //        {
        //            conn.Open();
        //            SqlDataReader dataReader;
        //            using (SqlCommand command = new SqlCommand("Select PostNr, Distrikt From Post", conn))
        //            {
        //                dataReader = command.ExecuteReader();
        //                while (dataReader.Read())
        //                {
        //                    liste.Add(new PostNumre { PostNummer = Convert.ToInt32(dataReader.GetValue(0)), Distrikt= dataReader.GetValue(1).ToString() });
        //                }
        //            }
        //        }
        //    }
        //    catch (SqlException e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //    return liste;
        //}
    }
}
