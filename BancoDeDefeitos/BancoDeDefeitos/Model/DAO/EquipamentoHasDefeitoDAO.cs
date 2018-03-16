using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDefeitos.Model.DAO
{
    class EquipamentoHasDefeitoDAO
    {
        bool statusOk = false;
        public bool Create(int equipId,int defeitoID,string obs)
        {
            

            MySqlConnection conexao = MySQLConn.GetInstancia().GetConexao();

            conexao.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = conexao;
            command.CommandType = System.Data.CommandType.Text;

            try
            {
                if (obs.Equals(""))
                {

                    obs = "default";
                }


                command.CommandText = "INSERT INTO equipamento_has_defeito (Equipamento_Id,Defeito_Id,observacao)  VALUES (@equipId,@defeitoId,@obs);";

                command.Parameters.AddWithValue("@equipId", equipId);
                command.Parameters.AddWithValue("@defeitoId", defeitoID);
                command.Parameters.AddWithValue("@obs", obs);
               
                command.ExecuteNonQuery();


                
                conexao.Close();
                statusOk = true;
            }
            catch (Exception e)
            {
                statusOk = false;
                conexao.Close();
                throw e;

            }


            return statusOk;
           
        }


        public List<DataGridObject> readByCriteria(String criteria)
        {

            MySqlConnection conexao = MySQLConn.GetInstancia().GetConexao();

            conexao.Open();
            List<DataGridObject> listObjs = null;

            try
            {

                listObjs = new List<DataGridObject>();


                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT tb.Id as Equipamento_Id,tb.Marca as Marca ,tb.Tipo as Tipo, tb.Modelo as Modelo, equipamento_has_defeito.Observacao as Obs, defeito.Id as Defeito_Id ," +
                    " defeito.DescricaoDefeito as Sintoma ,defeito.Peca as Peca,defeito.Causa as Causa ,defeito.Solucao as Solucao FROM " +
                    "(SELECT equipamento.Id as Id, modelo.Modelo as Modelo,marca.Nome as Marca,tipoequipamento.Tipo as Tipo FROM equipamento " +
                    "join modelo on equipamento.Modelo_Id = modelo.Id JOIN marca ON equipamento.Marca_Id = marca.Id " +
                    "JOIN tipoequipamento ON equipamento.TipoEquipamento_Id = tipoequipamento.Id where modelo.Modelo = @criteria) " +
                     "tb  join equipamento_has_defeito ON tb.Id = equipamento_has_defeito.Equipamento_Id JOIN defeito ON equipamento_has_defeito.Defeito_Id = defeito.Id;";
                command.Parameters.AddWithValue("@criteria", criteria);

                MySqlDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);


                if (dr.HasRows)
                {
                    DataGridObject dto = new DataGridObject();


                    while (dr.Read())
                    {

                        dto.Causa = (string)dr["Causa"];

                        dto.Defeito_Id = Convert.ToInt32(dr["Defeito_Id"]);

                        dto.EquipId = Convert.ToInt32(dr["Equipamento_Id"]);

                        dto.Marca = (string)dr["Marca"];

                        dto.Modelo = (string)dr["Modelo"];

                        dto.Observacao = (string)dr["Obs"];

                        dto.Peca = (string)dr["Peca"];

                        dto.Sintoma = (string)dr["Sintoma"];

                        dto.Solucao = (string)dr["Solucao"];

                        dto.Tipo = (string)dr["Tipo"];

                        listObjs.Add(dto);

                        dto = new DataGridObject();

                    }

                }

            }
            catch (Exception e)
            {
                listObjs = null;
                throw e;

            }


            return listObjs;

        }


    }
}
