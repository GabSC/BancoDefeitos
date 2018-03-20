using BancoDeDefeitos.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDefeitos.Controller
{
    class AplicacaoController
    {

        public bool RealizarBackupDoBD(String caminho)
        {

            BackupRestore BR = new BackupRestore();

           return BR.Backup(caminho);

        }


        public bool ImportarBackupDoBD(String caminho)
        {

            BackupRestore BR = new BackupRestore();

            return BR.Restore(caminho);
        }
    }
}
