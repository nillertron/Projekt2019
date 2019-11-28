using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjektOpgave1Sem2019.Model
{
    class PostNrTabelDB
    {
        public static List<PostNumre> GetAllPostnumre()
        {
            var liste = new List<PostNumre>();
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();
                    SqlDataReader dataReader;
                    using (SqlCommand command = new SqlCommand("Select PostNr, Distrikt From Post", conn))
                    {
                        dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            liste.Add(new PostNumre { PostNummer = Convert.ToInt32(dataReader.GetValue(0)), Distrikt = dataReader.GetValue(1).ToString() });
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
