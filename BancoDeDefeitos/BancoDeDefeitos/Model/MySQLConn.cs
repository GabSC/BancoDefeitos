using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BancoDeDefeitos.Model
{
    class MySQLConn
    {
        private static readonly MySQLConn instanciaMySQLConn = new MySQLConn();

        private MySQLConn() { }

        public static MySQLConn GetInstancia()
        {

            return instanciaMySQLConn;
        }

        public MySqlConnection GetConexao()
        {

            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            return new MySqlConnection(conn);
        }

    }
}
