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
        /*
         * Tænker at vi har 3 strenge herinde som vi lader stå, så kan man selv udkommentere de andres og køre med sin egen :)
         */
        //private static const string connString = "Data Source = DESKTOP-TEM8DQC\\MARTINSQL; Initial Catalog = RealBoligDB; Integrated Security = SSPI";
       // private static string connString = "Data Source=DESKTOP-VB98SL1;Initial Catalog=RealBoligDB;Integrated Security=True";
        private static string connString = "Data Source=LAPTOP-SJJU562U;Initial Catalog=RealBoligDB;Integrated Security=True";


        public static string ConnString { get => connString; }
        private static SqlConnection conn = new SqlConnection(connString);
        public static SqlConnection Conn { get => conn; }

    }
}
