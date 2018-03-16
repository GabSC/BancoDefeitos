using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDefeitos.Model.DAO
{
    class MarcaDAO
    {

        public void Create(String marca)
        {

            MySqlConnection conexao = MySQLConn.GetInstancia().GetConexao();

            conexao.Open();

            

            try
            {
                

                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO marca (Nome) VALUE (@nome);";

                command.Parameters.AddWithValue("@nome",marca);


                command.ExecuteNonQuery();

                conexao.Close();

            }catch (Exception e )
            {
                conexao.Close();
                throw e;

            }


        }

        public List<Marca> ReadAll()
        {

            MySqlConnection conexao = MySQLConn.GetInstancia().GetConexao();

            conexao.Open();
            List<Marca> listMarcas = null;

            try {

             listMarcas  = new List<Marca>();


                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM marca";

                MySqlDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);


                if (dr.HasRows)
                {
                    Marca m = new Marca();


                    while (dr.Read())
                    {

                        m.Id = (int)dr["Id"];
                        m.Nome = (string)dr["Nome"];

                        listMarcas.Add(m);

                        m = new Marca();
                    }

                }

            }
            catch (Exception e)
            {
                listMarcas = null;
                throw e;

            }


            return listMarcas;

        }

    }
}
