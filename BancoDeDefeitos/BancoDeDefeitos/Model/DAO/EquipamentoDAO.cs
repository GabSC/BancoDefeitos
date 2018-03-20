using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDefeitos.Model.DAO
{
    class EquipamentoDAO
    {

        public int Create(Equipamento equip)
        {
            int id = 0;
            MySqlConnection conexao = MySQLConn.GetInstancia().GetConexao();

            

            conexao.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = conexao;
            command.CommandType = System.Data.CommandType.Text;

           

            try
            {

                
               
                command.CommandText = "INSERT INTO Equipamento (Marca_Id,TipoEquipamento_Id,Modelo_Id) VALUE (@marcaID,@TipoID,@ModeloID);";

                command.Parameters.AddWithValue("@marcaID", equip.marca.Id);
                command.Parameters.AddWithValue("@TipoID", equip.tipo.Id);
                command.Parameters.AddWithValue("@ModeloID", equip.modelo.Id);

                command.ExecuteNonQuery();


                command.CommandText = "SELECT LAST_INSERT_ID() as id;";
                MySqlDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        id = Convert.ToInt32( dr["id"]);

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

    }
}
