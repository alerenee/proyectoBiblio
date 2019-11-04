using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Conexion
    {
        public SqlConnection conexion()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conexion);
            conn.Open();
            return conn;
        }
    }
}
