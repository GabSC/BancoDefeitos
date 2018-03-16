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
    public partial class AdicionarMarca : Form
    {

       
        public AdicionarMarca()
        {
            InitializeComponent();
        }

       

        private void btnSalvarMarca_Click(object sender, EventArgs e)
        {

            

            Marca m = new Marca();

            m.Nome = txbAddMarca.Text.ToUpper() ;

            if(!String.IsNullOrEmpty(m.Nome) && !String.IsNullOrWhiteSpace(m.Nome)) {



                List<ValidationResult> listErros = new List<ValidationResult>();
                ValidationContext contexto = new ValidationContext(m);
                bool validado = Validator.TryValidateObject(m, contexto, listErros, true);


                if (validado)
                {

                    CadastrarEquipamentoController ctrl = new CadastrarEquipamentoController();

                    ctrl.AdicionarMarca(m.Nome);
                    txbAddMarca.Clear();
                    lbErros.Text = "Salvo com sucesso!";
                }
                else
                {


                    StringBuilder sb = new StringBuilder();

                    foreach (var erros in listErros)
                    {

                        sb.Append(erros.ErrorMessage + "\n");

                    }

                    lbErros.Text = sb.ToString();
                }

            }
            else
            {

                lbErros.Text = "Campo vazio!!";
                lbErros.ForeColor = Color.Red;
            }


        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
