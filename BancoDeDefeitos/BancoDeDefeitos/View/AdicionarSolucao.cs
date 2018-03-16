using BancoDeDefeitos.Controller;
using BancoDeDefeitos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeDefeitos.View
{
    public partial class AdicionarSolucao : Form
    {
        private DataGridObject dadosPassados = null;
        private int equipamentoId = 0;

        public AdicionarSolucao()
        {
            InitializeComponent();
        }

        public AdicionarSolucao(DataGridObject obj)
        {
            InitializeComponent();
            dadosPassados = obj;
            Inicialiar();
        }

        public AdicionarSolucao(int equipID)
        {
            InitializeComponent();

            equipamentoId = equipID;
        }

        private void Inicialiar()
        {
            txbPeca.Text = dadosPassados.Peca;
            txtCausa.Text = dadosPassados.Causa;
            txtDefeito.Text = dadosPassados.Sintoma;
            txtSolucao.Text = dadosPassados.Solucao;

        }

        private void btnSalvaSolucao_Click(object sender, EventArgs e)
        {
            DataGridObject obj = new DataGridObject();


            obj.EquipId = equipamentoId;
            obj.Peca = txbPeca.Text.Trim().ToUpper();
            obj.Sintoma = txtDefeito.Text.Trim().ToUpper();
            obj.Causa = txtCausa.Text.Trim().ToUpper();
            obj.Solucao = txtSolucao.Text.Trim().ToUpper();

            List<ValidationResult> listErros = new List<ValidationResult>();
            ValidationContext contexto = new ValidationContext(obj);

            bool validado = Validator.TryValidateObject(obj,contexto,listErros,true);

            if (validado)
            {

                if (dadosPassados == null && equipamentoId > 0)
                {
                    PesquisarEquipamentoController ctrl = new PesquisarEquipamentoController();
                    //adciono uma nova solução

                    

                    var salvo = ctrl.SalvarNovaSolucao(obj);

                    if (salvo)
                    {


                        lbStatus.Text = "Novo defeito adicionando com sucesso!";
                        lbStatus.ForeColor = Color.SpringGreen;
                        txbPeca.Clear();
                        txtCausa.Clear();
                        txtDefeito.Clear();
                        txtSolucao.Clear();
                    }
                    else
                    {

                        lbStatus.Text = "Ocorreu um erro ao salvar novo defeito!";

                        lbStatus.ForeColor = Color.Red;


                    }

                }
                else
                {
                    //edito solução existente
                    dadosPassados.Peca = txbPeca.Text.Trim().ToUpper();
                    dadosPassados.Causa = txtCausa.Text.Trim().ToUpper();
                    dadosPassados.Sintoma = txtDefeito.Text.Trim().ToUpper();
                    dadosPassados.Solucao = txtSolucao.Text.Trim().ToUpper();

                    PesquisarEquipamentoController ctrl = new PesquisarEquipamentoController();

                    bool editado = ctrl.EditarSolucao(dadosPassados);

                    if (editado)
                    {
                        lbStatus.Text = "Editado com sucesso!";
                        lbStatus.ForeColor = Color.SpringGreen;
                        txbPeca.Clear();
                        txtCausa.Clear();
                        txtDefeito.Clear();
                        txtSolucao.Clear();
                        dadosPassados = null;
                    }
                    else
                    {

                        lbStatus.Text = "Ocorreu um erro!";
                        lbStatus.ForeColor = Color.Red;

                    }

                }


            }
            else
            {

                StringBuilder sb = new StringBuilder();

                foreach (var erro in listErros)
                {
                    sb.Append(erro.ErrorMessage + " ");
                }

                lbStatus.Text = sb.ToString();
                lbStatus.ForeColor = Color.Red;
            }

            

        }

        private void btnCancelarSolucao_Click(object sender, EventArgs e)
        {

            txbPeca.Clear();
            txtCausa.Clear();
            txtDefeito.Clear();
            txtSolucao.Clear();
            this.Close();

        }
    }
}
