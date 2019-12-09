using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ProjektOpgave1Sem2019.Model.Kunde
{
    class KundeDBTabel
    {
        //dette mesterværk er lavet hovedsageligt af nichlas <3
        public static Køber GetSpecifikKøberMedID(int id)
        {
            var køber = new Køber();
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();
                    SqlDataReader dataReader;
                    using (SqlCommand command = new SqlCommand("Select * from Køber where id = @id", conn))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.Value = id;
                        command.Parameters.Add(param);
                        dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            køber = new Køber(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetInt32(5), dataReader.GetString(6));
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return køber;

        }


        public static Sælger GetSpecifikSælgerMedID(int id)
        {
            var sælger = new Sælger();
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();
                    SqlDataReader dataReader;
                    using (SqlCommand command = new SqlCommand("select * from Sælger where id=@id", conn))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.Value = id;
                        command.Parameters.Add(param);
                        dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                            sælger=new Sælger(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetInt32(5), dataReader.GetString(6));




                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return sælger;
        }


        //karl 
        public static List<Køber> GetAllKøbere()
        {

                var liste = new List<Køber>();
                try
                {
                    using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                    {
                        conn.Open();
                        SqlDataReader dataReader;
                        using (SqlCommand command = new SqlCommand("Select * from Køber ", conn))
                        {
                            dataReader = command.ExecuteReader();
                            while (dataReader.Read())
                            {
                            liste.Add(new Køber(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetInt32(5), dataReader.GetString(6)));
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
        public static List<Sælger> GetAllSælgere()
        {
            var liste = new List<Sælger>();
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();
                    SqlDataReader dataReader;
                    using (SqlCommand command = new SqlCommand("select * from Sælger", conn))
                    {
                        Sælger sælger = new Sælger();
                        dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                            liste.Add(new Sælger(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetInt32(5), dataReader.GetString(6)));




                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return liste;
        }

        public static bool UpdateKøber(Køber k)
        {
            
            bool succes = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("Update Køber set Adresse =@adresse,efternavn = @efternavn, Kontonr =@kontonr, PostNr = @postnr,Tlf=@telefonnr,fornavn = @navn where ID = @id", conn);

                    //command.Parameters.Add("@adresse", SqlDbType.NVarChar);
                    //command.Parameters["@adresse"].Value = k.Addresse;
                    command.Parameters.AddWithValue("@adresse", k.Addresse);
                        command.Parameters.Add("@efternavn", SqlDbType.NVarChar);
                        command.Parameters["@efternavn"].Value =k.Efternavn;
                        command.Parameters.Add("@kontonr", SqlDbType.NVarChar);
                        command.Parameters["@kontonr"].Value = k.KontoNr;
                        command.Parameters.Add("@postnr",SqlDbType.Int);
                        command.Parameters["@postnr"].Value = k.PostNr;
                        command.Parameters.Add("@telefonnr",SqlDbType.NVarChar);
                        command.Parameters["@telefonnr"].Value = k.TelefonNr;
                        command.Parameters.Add("@navn", SqlDbType.NVarChar);
                        command.Parameters["@navn"].Value = k.Navn;
                        command.Parameters.Add("@id",SqlDbType.Int);
                        command.Parameters["@id"].Value = k.Id;
                        command.ExecuteNonQuery();
                        succes = true;
                    
                }
            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.Message);
            }
            return succes;
        }
        public static bool UpdateSælger(Sælger k)
        {

            bool succes = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("Update Sælger set Adresse =@adresse,efternavn = @efternavn, Kontonr =@kontonr, PostNr = @postnr,Tlf=@telefonnr,fornavn = @navn where ID = @id", conn))
                    {
                        command.Parameters.AddWithValue("@adresse", k.Addresse);
                        command.Parameters.Add("@efternavn", SqlDbType.NVarChar);
                        command.Parameters["@efternavn"].Value = k.Efternavn;
                        command.Parameters.Add("@kontonr", SqlDbType.NVarChar);
                        command.Parameters["@kontonr"].Value = k.KontoNr;
                        command.Parameters.Add("@postnr", SqlDbType.Int);
                        command.Parameters["@postnr"].Value = k.PostNr;
                        command.Parameters.Add("@telefonnr", SqlDbType.NVarChar);
                        command.Parameters["@telefonnr"].Value = k.TelefonNr;
                        command.Parameters.Add("@navn", SqlDbType.NVarChar);
                        command.Parameters["@navn"].Value = k.Navn;
                        command.Parameters.Add("@id", SqlDbType.Int);
                        command.Parameters["@id"].Value = k.Id;
                        command.ExecuteNonQuery();
                        succes = true;

                    }
                }
            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.Message);
            }
            return succes;
        }

        public static bool SletSælger(Sælger k)
        {

            bool succes = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("Delete from sælger where id = @id", conn))
                    {
                        command.Parameters.AddWithValue("@id", k.Id);
                        command.ExecuteNonQuery();
                        succes = true;
                    }
                }
            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.Message);
            }
            return succes;
        }
        public static bool SletKøber(Køber k)
        {

            bool succes = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("Delete from Køber where id = @id", conn))
                    {
                        command.Parameters.AddWithValue("@id", k.Id);

                        command.ExecuteNonQuery();
                        succes = true;
                    }
                }
            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.Message);
            }
            return succes;
        }

        public static bool OpretKøber(Køber k)
        {

            var succes = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("Insert into Køber (Fornavn, Efternavn, Tlf, KontoNr, PostNr, Adresse) " +
                        "Values (@navn, @efternavn, @tlf, @kontonr, @postnr, @adresse)", conn))
                    {
                        command.Parameters.AddWithValue("@navn", k.Navn);
                        command.Parameters.AddWithValue("@efternavn", k.Efternavn);
                        command.Parameters.AddWithValue("@tlf", k.TelefonNr);
                        command.Parameters.AddWithValue("@kontonr", k.KontoNr);
                        command.Parameters.AddWithValue("@postnr", k.PostNr);
                        command.Parameters.AddWithValue("@adresse", k.Addresse);


                        command.ExecuteNonQuery();
                    }
                    SqlDataReader reader;
                    using (SqlCommand command = new SqlCommand("SELECT TOP 1 ID FROM Køber ORDER BY ID DESC", conn))
                    {
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            k.Id = reader.GetInt32(0);

                        }
                    }
                    succes = true;
                }
            

                
            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.Message);
            }
            return succes;
        }


        public static bool OpretSælger(Sælger k)
        {
            var succes = false;            
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("Insert into Sælger (Fornavn, Efternavn, Tlf, KontoNr, PostNr, Adresse) " +
                        "Values (@navn, @efternavn, @tlf, @kontonr, @postnr, @adresse)", conn))
                    {
                        command.Parameters.AddWithValue("@navn", k.Navn);
                        command.Parameters.AddWithValue("@efternavn", k.Efternavn);
                        command.Parameters.AddWithValue("@tlf", k.TelefonNr);
                        command.Parameters.AddWithValue("@kontonr", k.KontoNr);
                        command.Parameters.AddWithValue("@postnr", k.PostNr);
                        command.Parameters.AddWithValue("@adresse", k.Addresse);


                        command.ExecuteNonQuery();
                    }

                    k.Id = DBHelper.GetNewestIdFromTabel("Sælger", conn);
                    succes = true;
                }
            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.Message);
            }

            return succes;

        }

        //Martin
        public static Sælger GetSælger(int id) //Til at få enkelt sælger under Edit bolig
        {
            Sælger returnSælger;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = DBHelper.Conn;
                cmd.CommandText = "SELECT * FROM Sælger WHERE ID = @ID";

                cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = id;

                DBHelper.Conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    returnSælger = new Sælger(reader.GetInt32(0), reader.GetString(1),
                                        reader.GetString(2), reader.GetString(3),
                                        reader.GetString(4), reader.GetInt32(5), reader.GetString(6));
                }
                DBHelper.Conn.Close();
            }
            return returnSælger;
        }
        //Martin slut
    }
   
}



