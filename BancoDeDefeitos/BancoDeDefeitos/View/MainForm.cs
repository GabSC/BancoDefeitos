using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeDefeitos.View
{
    public partial class MainForm : Form
    {
        CadastrarEquipamentos formCadastro = null;

        TelaPesquisarSolucao formPesquisar = null;

        Ajuda formAjuda = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void cadastrarEquipamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            

            if(formCadastro == null || formCadastro.IsDisposed == true)
            {

                formCadastro = new CadastrarEquipamentos();

                formCadastro.MdiParent = this; 

                formCadastro.Activate();
                formCadastro.Enabled = true;
                formCadastro.Show();
                

            }

        }

        private void FormCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pesquisarSoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

          

            if (formPesquisar == null || formPesquisar.IsDisposed == true)
            {

                formPesquisar = new TelaPesquisarSolucao();

                formPesquisar.MdiParent = this;

                formPesquisar.Activate();
                formPesquisar.Enabled = true;
                formPesquisar.Show();


            }

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (formAjuda == null || formAjuda.IsDisposed == true)
            {

                formAjuda = new Ajuda();



                formAjuda.Activate();
                formAjuda.Enabled = true;
                formAjuda.Show();


            }


        }
    }
}

// tirar  a restrição de sintoma da tela de editar ou adicionar ou modificar no model