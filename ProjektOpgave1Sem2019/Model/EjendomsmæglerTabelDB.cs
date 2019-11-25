using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
                
                while(reader.Read())
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
    }
}
