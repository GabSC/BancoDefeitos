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
    public partial class AddModelo : Form
    {
        public AddModelo()
        {
            InitializeComponent();
        }

        private void btnAddModelo_Click(object sender, EventArgs e)
        {
                        

            Modelo m = new Modelo();
            m.Nome = txbAddModelo.Text.Trim().ToUpper();

            if(!String.IsNullOrEmpty(m.Nome) && !String.IsNullOrWhiteSpace(m.Nome))
            {
                CadastrarEquipamentoController ctrl = new CadastrarEquipamentoController();
                List<ValidationResult> listErros = new List<ValidationResult>();
                ValidationContext contexto = new ValidationContext(m);

                bool validado = Validator.TryValidateObject(m, contexto, listErros, true);

                if (validado)
                {

                    ctrl.AdicionarModelo(m.Nome);
                    txbAddModelo.Clear();
                    lbErros.Text = "Salvo com sucesso!";
                    lbErros.ForeColor = Color.SpringGreen;
                }
                else
                {

                    StringBuilder sb = new StringBuilder();

                    foreach (var erro in listErros)
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

        private void btnCancelarModelo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
