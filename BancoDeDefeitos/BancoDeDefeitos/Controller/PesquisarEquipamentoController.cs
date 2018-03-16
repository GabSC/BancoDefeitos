using BancoDeDefeitos.Model;
using BancoDeDefeitos.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDefeitos.Controller
{
    class PesquisarEquipamentoController
    {

        public List<DataGridObject> pesquisar (String modelo)
        {

            EquipamentoHasDefeitoDAO DAO = new EquipamentoHasDefeitoDAO();

           return DAO.readByCriteria(modelo);

        }


        public bool EditarSolucao(DataGridObject obj)
        {

            DefeitoDAO DAO = new DefeitoDAO();

           return DAO.Update(obj);

        }

        public bool SalvarNovaSolucao(DataGridObject obj)
        {
            bool statusOk = false;
            

            Defeito d = new Defeito();

            d.Causa = obj.Causa;
            d.DescricaoDefeito = obj.Sintoma;
            d.Peca = obj.Peca;
            d.Solucao = obj.Solucao;
            DefeitoDAO DAO = new DefeitoDAO();

           var idNovoDefeito =  DAO.Create(d);

            if(idNovoDefeito > 0)
            {

                EquipamentoHasDefeitoDAO HasDAO = new EquipamentoHasDefeitoDAO();

               var gravado = HasDAO.Create(obj.EquipId, idNovoDefeito, "");


                if (gravado)
                {
                    statusOk = true;

                }

            }


            return statusOk;
        }

    }
}
