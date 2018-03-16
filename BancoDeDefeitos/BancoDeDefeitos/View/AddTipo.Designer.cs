namespace BancoDeDefeitos.View
{
    partial class AddTipo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbAddProduto = new System.Windows.Forms.TextBox();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.btnCancelarProduto = new System.Windows.Forms.Button();
            this.lbErros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto:";
            // 
            // txbAddProduto
            // 
            this.txbAddProduto.Location = new System.Drawing.Point(62, 104);
            this.txbAddProduto.Name = "txbAddProduto";
            this.txbAddProduto.Size = new System.Drawing.Size(182, 20);
            this.txbAddProduto.TabIndex = 1;
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Location = new System.Drawing.Point(62, 220);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduto.TabIndex = 2;
            this.btnAddProduto.Text = "Salvar";
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // btnCancelarProduto
            // 
            this.btnCancelarProduto.Location = new System.Drawing.Point(169, 220);
            this.btnCancelarProduto.Name = "btnCancelarProduto";
            this.btnCancelarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarProduto.TabIndex = 3;
            this.btnCancelarProduto.Text = "Cancelar";
            this.btnCancelarProduto.UseVisualStyleBackColor = true;
            this.btnCancelarProduto.Click += new System.EventHandler(this.btnCancelarProduto_Click);
            // 
            // lbErros
            // 
            this.lbErros.AutoSize = true;
            this.lbErros.Location = new System.Drawing.Point(15, 167);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(0, 13);
            this.lbErros.TabIndex = 4;
            // 
            // AddTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbErros);
            this.Controls.Add(this.btnCancelarProduto);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.txbAddProduto);
            this.Controls.Add(this.label1);
            this.Name = "AddTipo";
            this.Text = "Adicionar tipo/produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAddProduto;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Button btnCancelarProduto;
        private System.Windows.Forms.Label lbErros;
    }
}