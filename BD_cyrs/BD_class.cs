using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using BD_cyrs;
using System.Data;

namespace BD_cyrs
{
    class BD_class
    {
        static string connectionString = "Server=HOME-PC;Database=DB_HUMAN_RESOURCES_DEP;Trusted_Connection=True;TrustServerCertificate=True;";

        public static DataTable Connec(string sqlExpression)
        {
            SqlCommand cmd = new SqlCommand(sqlExpression);
            SqlDataAdapter da = new SqlDataAdapter(sqlExpression, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public static void connect(string sqlExpression)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }

    }

    public class Connect
        {
            private static volatile Connect stringCon;

            private string _data;

            public string Data => _data;

            private Connect(string data)
            {
                _data = data;
            }

            public static Connect GetInst(string data)
            {
                if (string.IsNullOrEmpty(data))
                {
                    throw new ArgumentNullException(nameof(data));
                }
                if (stringCon == null)
                {
                    stringCon = new Connect(data);
                }

                return stringCon;
            }

            public override string ToString()
            {
                return Data;
            }
        }
}
