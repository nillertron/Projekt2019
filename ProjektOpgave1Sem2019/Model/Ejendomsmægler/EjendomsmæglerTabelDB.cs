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
        public static List<Ejendomsmægler> GetAllEgendomsmæglere()
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
                    returnList.Add(new Ejendomsmægler(reader.GetInt32(0),
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

        //prøvede lige at lave et par metoder til at læse og oprette fra DB
        //Husk at ændre db brugeren til at være fra DK for at kunne bruge datetime fra c#!
        //Security -> logins -> bruger, højreklik -> properties -> nederst ændre default language til dansk
        public static async Task OpretEjendomsmægler(Ejendomsmægler data)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();


                    using (SqlCommand command = new SqlCommand("Insert into Ejendomsmægler (Fornavn, Efternavn, Tlf, Fødselsdato, KontoNr) values ('" + data.Navn + "', '" + data.Efternavn + "','" + data.TelefonNr + "', '"+ data.Fødseldato + "', '"+data.KontoNr+"')"))
                    {
                        command.Connection = conn;
                        await command.ExecuteNonQueryAsync();
                    }

                    MessageBox.Show("Done!");
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static async Task<List<Ejendomsmægler>> GetAllEjendomsmæglere()
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
                        dataReader = await command.ExecuteReaderAsync();
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
