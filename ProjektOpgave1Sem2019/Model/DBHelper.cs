using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjektOpgave1Sem2019.Model
{
    class DBHelper
    {
        private static string connString = "Data Source = DESKTOP-TEM8DQC\\MARTINSQL; Initial Catalog = RealBoligDB; Integrated Security = SSPI";
        private static SqlConnection conn = new SqlConnection(connString);
        public static SqlConnection Conn
        {
            get
            {
                return conn;
            }
        }
    }
}
