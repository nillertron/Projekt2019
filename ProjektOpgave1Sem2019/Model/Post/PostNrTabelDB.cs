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
        //Nichlas
        public static List<PostNumre> GetAllPostnumre()
        {
            var liste = new List<PostNumre>();
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();
                    SqlDataReader dataReader;
                    using (SqlCommand command = new SqlCommand("Select PostNr, Distrikt, KvmPris From Post", conn))
                    {
                        dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            liste.Add(new PostNumre { PostNummer = Convert.ToInt32(dataReader.GetValue(0)), Distrikt = dataReader.GetValue(1).ToString(), PrisPrm2=Convert.ToDouble(dataReader.GetValue(2)) });
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

        public static void OpdaterGennemsnitsPrisPrM2IEtPostNummer(int postNummer)
        {//Kaldes efter at have indsat en ny bolig
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.ConnString))
                {
                    conn.Open();


                    using (SqlCommand command = new SqlCommand("update Post set KvmPris = (select Sum(Købspris/bolig.Kvm) from SolgtBolig inner join Bolig on bolig.ID = SolgtBolig.BoligID where PostNr="+postNummer+") where PostNr="+postNummer+""))
                    {
                        command.Connection = conn;
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
