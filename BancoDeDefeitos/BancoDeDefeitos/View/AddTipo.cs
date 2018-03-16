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
    public partial class AddTipo : Form
    {
        public AddTipo()
        {
            InitializeComponent();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {

           

           

            Tipo t = new Tipo();
            t.tipo = txbAddProduto.Text.Trim().ToUpper();

            if (!String.IsNullOrEmpty(t.tipo) && !String.IsNullOrWhiteSpace(t.tipo))
            {

                CadastrarEquipamentoController ctrl = new CadastrarEquipamentoController();
                List<ValidationResult> listErrors = new List<ValidationResult>();
                ValidationContext contexto = new ValidationContext(t);

                bool validado = Validator.TryValidateObject(t, contexto, listErrors, true);

                if (validado)
                {

                    ctrl.AdicionarTipo(t.tipo);
                    txbAddProduto.Clear();
                    lbErros.Text = "Salvo com sucesso!";
                }
                else
                {

                    StringBuilder sb = new StringBuilder();

                    foreach (var erro in listErrors)
                    {

                        sb.Append(erro.ErrorMessage + "\n");
                    }

                    lbErros.Text = sb.ToString();

                }

            }
            else
            {

                lbErros.Text = "Campo vazio!";
                lbErros.ForeColor = Color.Red;

            }

           

        }

        private void btnCancelarProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
