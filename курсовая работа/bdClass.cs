using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая_работа
{
     class bdClass
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LOPTOP-ILYA; Initial Catalog=racion_pitaniya; Integrated Security=True");
        public void opemConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

        }
        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }

        }
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
