using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDefeitos.Model.DAO
{
    class BackupRestore
    {
        private bool isOK = false;

        public bool Backup( string caminho)
        {

           

            try {

                String connString = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
                
                string file = caminho + "\\BancoDeDados " + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".sql";

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            
                            mb.ExportInfo.AddCreateDatabase = true;
                            mb.ExportToFile(file);
                            conn.Close();
                        }
                    }
                }

                isOK = true;

            } catch (Exception e) {

                isOK = false;
                throw e;

            }


            return isOK;


        }


        public bool Restore(String caminho)
        {


            try
            {

                String connString = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
                string file =  caminho ;

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ImportInfo.TargetDatabase = "bancodefeitos";
                            mb.ImportInfo.DatabaseDefaultCharSet = "utf8";
                            mb.ImportFromFile(file);
                            conn.Close();
                            isOK = true;
                        }
                    }
                }

            }
            catch (Exception e)
            {
                isOK = false;
                throw e;

            }


            return isOK;
        }

    }
}
