using BancoDeDefeitos.Controller;
using BancoDeDefeitos.Model;
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
    public partial class TelaPesquisarSolucao : Form
    {
      

        AdicionarSolucao addSolucaoForm = null;

        AdicionarSolucao editarSolucaoForm = null;

        private int EquipamentoIDPesquisado = 0;

        public TelaPesquisarSolucao()
        {
            InitializeComponent();
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

          
           if(!String.IsNullOrEmpty(txbPesquisar.Text) && !String.IsNullOrWhiteSpace(txbPesquisar.Text))
            {

                PesquisarEquipamentoController ctrl = new PesquisarEquipamentoController();

                var listaTemporaria = ctrl.pesquisar(txbPesquisar.Text.Trim().ToUpper());

                dtgSolucao.DataSource = listaTemporaria;

                EquipamentoIDPesquisado = listaTemporaria[0].EquipId;

            }
            else
            {

                lbStatus.Text = "Campo pesquisar vazio!";
                lbStatus.ForeColor = Color.Red;

            }

            

           
        }

        private void btnAddSolucao_Click(object sender, EventArgs e)
        {

            if (addSolucaoForm == null || addSolucaoForm.IsDisposed == true)
            {

                addSolucaoForm = new AdicionarSolucao(EquipamentoIDPesquisado);
                
                addSolucaoForm.Activate();
                addSolucaoForm.Enabled = true;
                addSolucaoForm.Show();


            }

        }

        private void dtgSolucao_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditarSolucao_Click(object sender, EventArgs e)
        {
            DataGridObject obj = new DataGridObject();

            foreach (DataGridViewRow row in dtgSolucao.SelectedRows)
            {

               

                obj.EquipId = Convert.ToInt32(row.Cells["EquipId"].Value);

                obj.Defeito_Id = Convert.ToInt32(row.Cells["Defeito_Id"].Value);
                obj.Causa = row.Cells["Causa"].Value.ToString();
                obj.Peca = row.Cells["Peca"].Value.ToString();
                obj.Sintoma = row.Cells["Sintoma"].Value.ToString();
                obj.Solucao = row.Cells["Solucao"].Value.ToString();

                obj.Observacao = row.Cells["Observacao"].Value.ToString();

                
            }

            if(editarSolucaoForm == null || editarSolucaoForm.IsDisposed == true)
            {

                editarSolucaoForm = new AdicionarSolucao(obj);

          

                editarSolucaoForm.Activate();
                editarSolucaoForm.Enabled = true;
                editarSolucaoForm.Show();


            }


           
        }

        private void dtgSolucao_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // esse eventp é chamado antes de gerar a tabele para poder realizar alguam operação antes 
            //da renderização
            this.dtgSolucao.Columns["EquipId"].Visible = false;
            this.dtgSolucao.Columns["Defeito_Id"].Visible = false;
            //---trecho de coddigo que faz com que o conteudo de cada celula fique visivel por completo
            //sem precisa ficar aumentando a largura das colunas manualmente
            dtgSolucao.Columns["Sintoma"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dtgSolucao.Columns["Causa"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dtgSolucao.Columns["Solucao"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dtgSolucao.Columns["Peca"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dtgSolucao.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnCancelarPesq_Click(object sender, EventArgs e)
        {

            txbPesquisar.Clear();
            this.Close();

        }
    }
}


