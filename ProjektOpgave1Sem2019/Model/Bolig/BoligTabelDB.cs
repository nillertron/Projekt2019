using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjektOpgave1Sem2019.Model;

namespace ProjektOpgave1Sem2019
{
    class BoligTabelDB
    {
        //Martin Start
        public static List<Bolig> GetAll()
        {
            List<Bolig> list = new List<Bolig>();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = DBHelper.Conn;
                cmd.CommandText = "SELECT * FROM Bolig B  WHERE NOT EXISTS(SELECT SB.BoligID FROM SolgtBolig SB WHERE SB.BoligID = B.ID)";

                DBHelper.Conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        list.Add(new Bolig(reader.GetInt32(0),
                                            reader.GetString(1),
                                            (double)reader.GetDecimal(2),
                                            reader.GetInt32(3),
                                            reader.GetInt32(4),
                                            reader.GetDateTime(5),
                                            reader.GetInt32(6),
                                            reader.GetInt32(7)));
                    }
                }
                DBHelper.Conn.Close();
            }

            return list;
        }
        //Martin slut
    }
}
