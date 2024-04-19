using System;
using System.Collections.Generic;
using SD = System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace active_way
{
    internal class Conection
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-N9HFFH1\MSQLSERVER; Initial Catalog=beebe; Integrated Security=True");
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

        public void openConnection()
        {
            if (sqlConnection.State == SD.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == SD.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlCommand commandConection(string commandString)
        {
            return new SqlCommand(commandString, sqlConnection);
        }
        public SqlDataAdapter getDataAdapter(string commandString)
        {
            return sqlDataAdapter;
        }
    }
   
}
