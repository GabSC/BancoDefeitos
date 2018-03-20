using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoDeDefeitos.Controller;
using MySql.Data.MySqlClient;

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

       

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {


            FolderBrowserDialog fbd = new FolderBrowserDialog();

            String caminho = "";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
               
             
                caminho = fbd.SelectedPath;
            }
           

            AplicacaoController app = new AplicacaoController();

            bool sucesso = app.RealizarBackupDoBD(caminho);

            if (sucesso)
            {

                lbSatus.Text = "Backup salvo com sucesso";
                lbSatus.ForeColor = Color.SpringGreen;

            }
            else
            {

                lbSatus.Text = "Erro ao exportar o banco!";
                lbSatus.ForeColor = Color.Red;

            }


        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {


            bool sucesso = false;



            OpenFileDialog ofd = new OpenFileDialog();

            string caminho = "";

           if(ofd.ShowDialog() == DialogResult.OK)
            {
                
                               
               caminho =  ofd.FileName;

            }

            string[] ext = ofd.SafeFileName.Split('.');

            if(ext[1].Equals("sql"))
            {

                AplicacaoController app = new AplicacaoController();

                sucesso = app.ImportarBackupDoBD(caminho);

                if (sucesso)
                {

                    lbSatus.Text = "Backup restaurado com sucesso";
                    lbSatus.ForeColor = Color.SpringGreen;

                }
                else
                {

                    lbSatus.Text = "Erro ao restaurar o banco!";
                    lbSatus.ForeColor = Color.Red;

                }

            }
            else
            {

                lbSatus.Text = "Arquivo de extensão inválida";
                lbSatus.ForeColor = Color.Red;

            }

           

            

        }
    }
}

// pesquisar melhor com o projeto baixado,como importar e automaticamente criar o bd se usar
//a  abordagem abaixo.

// desenvolver tela de ajuda, com os links do youtube explicando o fuincionamento do software.
//Desde a instalação do mySQL até a importação dos dados do programa para o banco de dados
