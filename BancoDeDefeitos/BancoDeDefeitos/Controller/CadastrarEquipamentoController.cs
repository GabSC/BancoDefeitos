using BancoDeDefeitos.Model;
using BancoDeDefeitos.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDefeitos.Controller
{
    class CadastrarEquipamentoController
    {

        public void AdicionarMarca(String marca)
        {

            MarcaDAO DAO = new MarcaDAO();

            DAO.Create(marca);

        }

        public List<Marca> getMarcas()
        {
            MarcaDAO DAO = new MarcaDAO();
            

            return DAO.ReadAll();
        }


        public void AdicionarModelo(String modelo)
        {

            ModeloDAO DAO = new ModeloDAO();

            DAO.Create(modelo);
        }

        public List<Modelo> getModelos()
        {

            ModeloDAO DAO = new ModeloDAO();

            return DAO.ReadAll(); ;
        }



        public void AdicionarTipo(String tipo)
        {


            TipoDAO DAO = new TipoDAO();
            DAO.Create(tipo);
        }

        public List<Tipo> getTipos()
        {
            TipoDAO DAO = new TipoDAO();

            return DAO.ReadAll();
        }

        


        public int SalvarEquipamento(Equipamento equip)
        {

            EquipamentoDAO DAO = new EquipamentoDAO();


           return DAO.Create(equip);
        }


        public bool SalvarDefeito(string defeito,string obs,int equipamentoID)
        {
            bool retorno = false;

            DefeitoDAO DAO = new DefeitoDAO();

            EquipamentoHasDefeitoDAO DAO_HAS = new EquipamentoHasDefeitoDAO();

            Defeito obj = new Defeito();

            obj.DescricaoDefeito = defeito;


            

          int defeitoID =  DAO.Create(obj);

            if(defeitoID > 0 && equipamentoID > 0)
            {


                DAO_HAS.Create(equipamentoID, defeitoID, obs);

                retorno = true;
            }

            return retorno;
        }

    }
}
