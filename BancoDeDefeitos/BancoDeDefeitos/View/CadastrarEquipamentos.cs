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
    public partial class CadastrarEquipamentos : Form
    {
        AdicionarMarca formMarca = null;

        AddModelo formModelo = null;

        AddTipo formProduto = null;

        public CadastrarEquipamentos()
        {
            InitializeComponent();
            alimentaComboBoxes();
        }

        private void btnAddMarca_Click(object sender, EventArgs e)
        {

           

            if(formMarca == null || formMarca.IsDisposed == true)
            {
                formMarca = new AdicionarMarca();
                formMarca.Activate();
                formMarca.Enabled = true;
                formMarca.Show();


            }



        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {

            if (formProduto == null || formProduto.IsDisposed == true)
            {
                formProduto = new AddTipo();
                formProduto.Activate();
                formProduto.Enabled = true;
                formProduto.Show();


            }

        }

        private void btnAddModelo_Click(object sender, EventArgs e)
        {

            if (formModelo == null || formModelo.IsDisposed == true)
            {
                formModelo = new AddModelo();
                formModelo.Activate();
                formModelo.Enabled = true;
                formModelo.Show();


            }

        }

        private void alimentaComboBoxes()
        {
            CadastrarEquipamentoController ctrl = new CadastrarEquipamentoController();


            foreach (var marca in ctrl.getMarcas())
            {
                
                cbxMarca.Items.Add(marca);
                
            }


            foreach (var tipos in ctrl.getTipos())
            {

                cbxProduto.Items.Add(tipos);

            }



            foreach (var modelo in ctrl.getModelos())
            {
                cbxModelo.Items.Add(modelo);
            }
            

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            var marca = (Marca) cbxMarca.SelectedItem;
            var modelo = (Modelo) cbxModelo.SelectedItem;
            var tipo =(Tipo) cbxProduto.SelectedItem;

            var observacao = txbOBS.Text;
            var sintomas = txbSintoma.Text;

           if(marca == null && modelo == null && tipo == null && String.IsNullOrEmpty(observacao) && String.IsNullOrEmpty(sintomas))
            {

                lbStatusMsg.Text = "Possui campos vazios!";
                lbStatusMsg.ForeColor = Color.Red;

            }
            else
            {

                Equipamento equip = new Equipamento();

                CadastrarEquipamentoController ctrl = new CadastrarEquipamentoController();



                equip.marca = marca;
                equip.modelo = modelo;
                equip.tipo = tipo;





                int idRetornado = ctrl.SalvarEquipamento(equip);

                bool validado = ctrl.SalvarDefeito(sintomas, observacao, idRetornado);

                if (validado)
                {

                    lbStatusMsg.Text = "Informações salvas com sucesso!";
                    lbStatusMsg.ForeColor = Color.SpringGreen;
                }
                else
                {

                    lbStatusMsg.Text = "Ocorreu um erro! As informações não foram salvas!";
                    lbStatusMsg.ForeColor = Color.Red;
                }

                txbOBS.Clear();
                txbSintoma.Clear();
                cbxMarca.ResetText();
                cbxModelo.ResetText();
                cbxProduto.ResetText();

            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            txbOBS.Clear();
            txbSintoma.Clear();
            cbxMarca.ResetText();
            cbxModelo.ResetText();
            cbxProduto.ResetText();

           
        }
    }
}

