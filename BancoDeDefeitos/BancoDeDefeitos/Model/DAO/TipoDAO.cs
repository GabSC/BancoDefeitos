using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDefeitos.Model.DAO
{
    class TipoDAO
    {

        public void Create(String tipo)
        {

            MySqlConnection conexao = MySQLConn.GetInstancia().GetConexao();

            conexao.Open();



            try
            {


                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO tipoEquipamento (Tipo) VALUE (@tipo);";

                command.Parameters.AddWithValue("@tipo", tipo);


                command.ExecuteNonQuery();

                conexao.Close();

            }
            catch (Exception e)
            {
                conexao.Close();
                throw e;

            }


        }



        public List<Tipo> ReadAll()
        {

            MySqlConnection conexao = MySQLConn.GetInstancia().GetConexao();

            conexao.Open();
            List<Tipo> listTipo = null;

            try
            {

                listTipo = new List<Tipo>();


                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM tipoequipamento";

                MySqlDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);


                if (dr.HasRows)
                {
                    Tipo m = new Tipo();


                    while (dr.Read())
                    {

                        m.Id = (int)dr["Id"];
                        m.tipo = (string)dr["Tipo"];

                        listTipo.Add(m);

                        m = new Tipo();
                    }

                }

            }
            catch (Exception e)
            {
                listTipo = null;
                throw e;

            }


            return listTipo;

        }




    }
}
