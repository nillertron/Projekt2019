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
    }
}
