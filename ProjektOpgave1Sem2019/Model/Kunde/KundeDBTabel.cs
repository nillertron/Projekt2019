using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOpgave1Sem2019.Model.Kunde
{
    class KundeDBTabel
    {
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
                    using (SqlCommand command = new SqlCommand("Update Køber set Adresse ="+k.Addresse+",efternavn = "+k.Efternavn+", Kontonr ="+k.KontoNr+", PostNr = "+k.PostNr+",Tlf="+k.TelefonNr+",fornavn = "+k.Navn+"where ID = "+k.Id,conn))
                    {
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
        public static bool UpdateSælger(Sælger k)
        {

            bool succes = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("Update Sælger set Adresse =" + k.Addresse + ",efternavn = " + k.Efternavn + ", Kontonr =" + k.KontoNr + ", PostNr = " + k.PostNr + ",Tlf=" + k.TelefonNr + ",fornavn = " + k.Navn + "where ID = " + k.Id, conn))
                    {
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
                    using (SqlCommand command = new SqlCommand("Delete from sælger where id ="+k.Id, conn))
                    {
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
                    using (SqlCommand command = new SqlCommand("Delete from Køber where id =" + k.Id, conn))
                    {
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

            bool succes = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("Insert into Køber (Fornavn, Efternavn, Tlf, KontoNr, PostNr, Adresse) " +
                        "Values ('"+k.Navn+"'),('"+k.Efternavn+"'),('"+k.TelefonNr+"'),('"+k.KontoNr+"'),"+k.PostNr+",('"+k.Addresse+"')", conn))
                    {
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
        public static bool OpretSælger(Sælger k)
        {

            bool succes = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("Insert into Sælger (Fornavn, Efternavn, Tlf, KontoNr, PostNr, Adresse) " +
                        "Values ('" + k.Navn + "'),('" + k.Efternavn + "'),('" + k.TelefonNr + "'),('" + k.KontoNr + "')," + k.PostNr + ",('" + k.Addresse + "')", conn))
                    {
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



