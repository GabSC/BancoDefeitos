namespace BancoDeDefeitos.View
{
    partial class TelaPesquisarSolucao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisarSolucao));
            this.label1 = new System.Windows.Forms.Label();
            this.txbPesquisar = new System.Windows.Forms.TextBox();
            this.dtgSolucao = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelarPesq = new System.Windows.Forms.Button();
            this.btnAddSolucao = new System.Windows.Forms.Button();
            this.btnEditarSolucao = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolucao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar modelo:";
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Location = new System.Drawing.Point(358, 65);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(205, 20);
            this.txbPesquisar.TabIndex = 1;
            // 
            // dtgSolucao
            // 
            this.dtgSolucao.AllowUserToAddRows = false;
            this.dtgSolucao.AllowUserToDeleteRows = false;
            this.dtgSolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSolucao.Location = new System.Drawing.Point(12, 144);
            this.dtgSolucao.Name = "dtgSolucao";
            this.dtgSolucao.ReadOnly = true;
            this.dtgSolucao.Size = new System.Drawing.Size(879, 179);
            this.dtgSolucao.TabIndex = 2;
            this.dtgSolucao.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgSolucao_DataBindingComplete);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(358, 108);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelarPesq
            // 
            this.btnCancelarPesq.Location = new System.Drawing.Point(488, 108);
            this.btnCancelarPesq.Name = "btnCancelarPesq";
            this.btnCancelarPesq.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarPesq.TabIndex = 4;
            this.btnCancelarPesq.Text = "Cancelar";
            this.btnCancelarPesq.UseVisualStyleBackColor = true;
            this.btnCancelarPesq.Click += new System.EventHandler(this.btnCancelarPesq_Click);
            // 
            // btnAddSolucao
            // 
            this.btnAddSolucao.Location = new System.Drawing.Point(12, 329);
            this.btnAddSolucao.Name = "btnAddSolucao";
            this.btnAddSolucao.Size = new System.Drawing.Size(128, 23);
            this.btnAddSolucao.TabIndex = 5;
            this.btnAddSolucao.Text = "Adicionar Solução";
            this.btnAddSolucao.UseVisualStyleBackColor = true;
            this.btnAddSolucao.Click += new System.EventHandler(this.btnAddSolucao_Click);
            // 
            // btnEditarSolucao
            // 
            this.btnEditarSolucao.Location = new System.Drawing.Point(171, 329);
            this.btnEditarSolucao.Name = "btnEditarSolucao";
            this.btnEditarSolucao.Size = new System.Drawing.Size(114, 23);
            this.btnEditarSolucao.TabIndex = 6;
            this.btnEditarSolucao.Text = "Editar Solução";
            this.btnEditarSolucao.UseVisualStyleBackColor = true;
            this.btnEditarSolucao.Click += new System.EventHandler(this.btnEditarSolucao_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(456, 338);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 13);
            this.lbStatus.TabIndex = 7;
            // 
            // TelaPesquisarSolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(903, 358);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnEditarSolucao);
            this.Controls.Add(this.btnAddSolucao);
            this.Controls.Add(this.btnCancelarPesq);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dtgSolucao);
            this.Controls.Add(this.txbPesquisar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "TelaPesquisarSolucao";
            this.Text = "Pesquisar Solução";
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolucao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPesquisar;
        private System.Windows.Forms.DataGridView dtgSolucao;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelarPesq;
        private System.Windows.Forms.Button btnAddSolucao;
        private System.Windows.Forms.Button btnEditarSolucao;
        private System.Windows.Forms.Label lbStatus;
    }
}