using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDefeitos.Model.DAO
{
    class ModeloDAO
    {

        public void Create(String modelo)
        {

            MySqlConnection conexao = MySQLConn.GetInstancia().GetConexao();

            conexao.Open();



            try
            {


                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO modelo (Modelo) VALUE (@modelo);";

                command.Parameters.AddWithValue("@modelo", modelo);


                command.ExecuteNonQuery();

                conexao.Close();

            }
            catch (Exception e)
            {
                conexao.Close();
                throw e;

            }


        }


        public List<Modelo> ReadAll()
        {

            MySqlConnection conexao = MySQLConn.GetInstancia().GetConexao();

            conexao.Open();
            List<Modelo> listModelo = null;

            try
            {

                listModelo = new List<Modelo>();


                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM modelo";

                MySqlDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);


                if (dr.HasRows)
                {
                    Modelo m = new Modelo();


                    while (dr.Read())
                    {

                        m.Id = (int)dr["Id"];
                        m.Nome = (string)dr["Modelo"];

                        listModelo.Add(m);

                        m = new Modelo();
                    }

                }

            }
            catch (Exception e)
            {
                listModelo = null;
                throw e;

            }


            return listModelo;

        }



    }




}
