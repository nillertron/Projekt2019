using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjektOpgave1Sem2019.Model
{
    class EgendomsmæglerTabelDB
    {
        public static List<Ejendomsmægler> GetAllEgendomsmæglere()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBHelper.Conn;
            cmd.CommandText = "SELECT * FROM Egendomsmægler";

            List<Ejendomsmægler> returnList = new List<Ejendomsmægler>();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                
                while(reader.Read())
                {
                    returnList.Add(new Ejendomsmægler(reader.GetInt32(0),
                                                        reader.GetString(1),
                                                        reader.GetString(2),
                                                        reader.GetString(3),
                                                        reader.GetString(4),
                                                        reader.GetDateTime(5)));
                }
            }

            return returnList;
        }
    }
}
