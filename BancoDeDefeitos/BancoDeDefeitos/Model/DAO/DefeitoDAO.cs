using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDefeitos.Model.DAO
{
    class DefeitoDAO
    {
        private bool statusOK = false;
        public int Create(Defeito defeito)
        {
            int id = 0;

            MySqlConnection conexao = MySQLConn.GetInstancia().GetConexao();

            conexao.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = conexao;
            command.CommandType = System.Data.CommandType.Text;

            if(String.IsNullOrEmpty(defeito.Causa) && String.IsNullOrEmpty(defeito.Solucao) && String.IsNullOrEmpty(defeito.Peca))
            {
                defeito.Causa = "default";
                defeito.Peca = "default";
                defeito.Solucao = "default";

            }

            try
            {

                


                command.CommandText = "INSERT INTO defeito (Peca,Solucao,DescricaoDefeito,Causa) VALUES (@Peca,@Solucao,@Descricao,@Causa);";

                command.Parameters.AddWithValue("@Peca", defeito.Peca);
                command.Parameters.AddWithValue("@Solucao", defeito.Solucao);
                command.Parameters.AddWithValue("@Descricao", defeito.DescricaoDefeito);
                command.Parameters.AddWithValue("@Causa", defeito.Causa);
                command.ExecuteNonQuery();


                command.CommandText = "SELECT LAST_INSERT_ID() as id;";
                MySqlDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        id = Convert.ToInt32(dr["id"]);

                    }

                }
                conexao.Close();

            }
            catch (Exception e)
            {
                conexao.Close();
                throw e;

            }



            return id;
        }


        public bool Update(DataGridObject obj)
        {
            
            MySqlConnection conexao = MySQLConn.GetInstancia().GetConexao();

            conexao.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = conexao;
            command.CommandType = System.Data.CommandType.Text;

            try
            {
                command.CommandText = "update defeito SET Peca = @Peca , Solucao = @Solucao, DescricaoDefeito = @Sintoma , Causa = @Causa where Id = @Id;";

                command.Parameters.AddWithValue("@Peca", obj.Peca);
                command.Parameters.AddWithValue("@Solucao", obj.Solucao);
                command.Parameters.AddWithValue("@Sintoma", obj.Sintoma);
                command.Parameters.AddWithValue("@Causa", obj.Causa);
                command.Parameters.AddWithValue("@Id", obj.Defeito_Id);
                command.ExecuteNonQuery();

                conexao.Close();
                statusOK = true;
            }
            catch(Exception e)
            {
                statusOK = false;
                conexao.Close();
                throw e;
            }


            return statusOK;

        }

    }
}
