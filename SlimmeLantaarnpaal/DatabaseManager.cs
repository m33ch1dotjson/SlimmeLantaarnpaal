using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SlimmeLantaarnpaal
{
    public class DatabaseManager
    {
        private string connectionString = "Server=DESKTOP-K01F946\\MSSQLSERVER01;Database=Lantaarnpaal;Trusted_Connection=True;";


        public void OpslaanMeetgegevens(int lantaarnpaalID, int lichtSterkte)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO SensorWaarde (LantaarnpaalID, Lichtsterkte) VALUES (@LantaarnpaalID, @Lichtsterkte)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LantaarnpaalID", lantaarnpaalID);
                    cmd.Parameters.AddWithValue("@Lichtsterkte", lichtSterkte);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
