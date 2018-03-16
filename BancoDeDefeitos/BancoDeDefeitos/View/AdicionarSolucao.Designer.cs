namespace BancoDeDefeitos.View
{
    partial class AdicionarSolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarSolucao));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDefeito = new System.Windows.Forms.TextBox();
            this.txtCausa = new System.Windows.Forms.TextBox();
            this.txtSolucao = new System.Windows.Forms.TextBox();
            this.btnSalvaSolucao = new System.Windows.Forms.Button();
            this.btnCancelarSolucao = new System.Windows.Forms.Button();
            this.lbPeca = new System.Windows.Forms.Label();
            this.txbPeca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Defeito:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Causa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Solução:";
            // 
            // txtDefeito
            // 
            this.txtDefeito.Location = new System.Drawing.Point(91, 18);
            this.txtDefeito.Multiline = true;
            this.txtDefeito.Name = "txtDefeito";
            this.txtDefeito.Size = new System.Drawing.Size(572, 54);
            this.txtDefeito.TabIndex = 3;
            // 
            // txtCausa
            // 
            this.txtCausa.Location = new System.Drawing.Point(91, 87);
            this.txtCausa.Multiline = true;
            this.txtCausa.Name = "txtCausa";
            this.txtCausa.Size = new System.Drawing.Size(572, 56);
            this.txtCausa.TabIndex = 4;
            // 
            // txtSolucao
            // 
            this.txtSolucao.Location = new System.Drawing.Point(91, 162);
            this.txtSolucao.Multiline = true;
            this.txtSolucao.Name = "txtSolucao";
            this.txtSolucao.Size = new System.Drawing.Size(572, 56);
            this.txtSolucao.TabIndex = 5;
            // 
            // btnSalvaSolucao
            // 
            this.btnSalvaSolucao.Location = new System.Drawing.Point(248, 339);
            this.btnSalvaSolucao.Name = "btnSalvaSolucao";
            this.btnSalvaSolucao.Size = new System.Drawing.Size(75, 23);
            this.btnSalvaSolucao.TabIndex = 6;
            this.btnSalvaSolucao.Text = "Salvar";
            this.btnSalvaSolucao.UseVisualStyleBackColor = true;
            this.btnSalvaSolucao.Click += new System.EventHandler(this.btnSalvaSolucao_Click);
            // 
            // btnCancelarSolucao
            // 
            this.btnCancelarSolucao.Location = new System.Drawing.Point(381, 339);
            this.btnCancelarSolucao.Name = "btnCancelarSolucao";
            this.btnCancelarSolucao.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarSolucao.TabIndex = 7;
            this.btnCancelarSolucao.Text = "Cancelar";
            this.btnCancelarSolucao.UseVisualStyleBackColor = true;
            this.btnCancelarSolucao.Click += new System.EventHandler(this.btnCancelarSolucao_Click);
            // 
            // lbPeca
            // 
            this.lbPeca.AutoSize = true;
            this.lbPeca.Location = new System.Drawing.Point(31, 247);
            this.lbPeca.Name = "lbPeca";
            this.lbPeca.Size = new System.Drawing.Size(35, 13);
            this.lbPeca.TabIndex = 8;
            this.lbPeca.Text = "Peça:";
            // 
            // txbPeca
            // 
            this.txbPeca.Location = new System.Drawing.Point(100, 239);
            this.txbPeca.Name = "txbPeca";
            this.txbPeca.Size = new System.Drawing.Size(563, 20);
            this.txbPeca.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(73, 309);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 13);
            this.lbStatus.TabIndex = 11;
            // 
            // AdicionarSolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(675, 374);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbPeca);
            this.Controls.Add(this.lbPeca);
            this.Controls.Add(this.btnCancelarSolucao);
            this.Controls.Add(this.btnSalvaSolucao);
            this.Controls.Add(this.txtSolucao);
            this.Controls.Add(this.txtCausa);
            this.Controls.Add(this.txtDefeito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdicionarSolucao";
            this.Text = "Adicionar/Editar solucao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDefeito;
        private System.Windows.Forms.TextBox txtCausa;
        private System.Windows.Forms.TextBox txtSolucao;
        private System.Windows.Forms.Button btnSalvaSolucao;
        private System.Windows.Forms.Button btnCancelarSolucao;
        private System.Windows.Forms.Label lbPeca;
        private System.Windows.Forms.TextBox txbPeca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbStatus;
    }
}