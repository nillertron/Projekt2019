using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjektOpgave1Sem2019.Model
{
    class DBHelper
    {
        /*
         * Tænker at vi har 3 strenge herinde som vi lader stå, så kan man selv udkommentere de andres og køre med sin egen :)
         */
      private static string connString = "Data Source = DESKTOP-TEM8DQC\\MARTINSQL; Initial Catalog = RealBoligDB; Integrated Security = SSPI";
        //private static string connString = "Data Source=DESKTOP-VB98SL1;Initial Catalog=RealBoligDB;Integrated Security=True";
      //  private static string connString = "Data Source=DESKTOP-G0E6LAI;Initial Catalog=RealBoligDB;Integrated Security=True";
        //private static string connString = "Data Source=LAPTOP-SJJU562U;Initial Catalog=RealBoligDB;Integrated Security=True";


        public static string ConnString { get { return connString; } }
        private static SqlConnection conn = new SqlConnection(connString);
        public static SqlConnection Conn { get { return conn; }  }

        public static int GetNewestIdFromTabel(string TabelNavn, SqlConnection OpenConn)
        {
            int newId = 0;
            
                try
                {
                        using (SqlCommand getIdCmd = new SqlCommand($"SELECT MAX(ID) AS ID FROM {TabelNavn} "))
                        {
                            getIdCmd.Connection = OpenConn;
                            using (SqlDataReader reader = getIdCmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                            newId = Convert.ToInt32(reader["ID"]);

                                }
                            }
                        }
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }

            return newId;
        }
    }

    
}
