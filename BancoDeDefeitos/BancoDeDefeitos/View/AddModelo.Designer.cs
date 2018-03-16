namespace BancoDeDefeitos.View
{
    partial class AddModelo
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
            this.txbAddModelo = new System.Windows.Forms.TextBox();
            this.btnAddModelo = new System.Windows.Forms.Button();
            this.btnCancelarModelo = new System.Windows.Forms.Button();
            this.lbErros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo:";
            // 
            // txbAddModelo
            // 
            this.txbAddModelo.Location = new System.Drawing.Point(56, 105);
            this.txbAddModelo.Name = "txbAddModelo";
            this.txbAddModelo.Size = new System.Drawing.Size(188, 20);
            this.txbAddModelo.TabIndex = 1;
            // 
            // btnAddModelo
            // 
            this.btnAddModelo.Location = new System.Drawing.Point(56, 216);
            this.btnAddModelo.Name = "btnAddModelo";
            this.btnAddModelo.Size = new System.Drawing.Size(75, 23);
            this.btnAddModelo.TabIndex = 2;
            this.btnAddModelo.Text = "Salvar";
            this.btnAddModelo.UseVisualStyleBackColor = true;
            this.btnAddModelo.Click += new System.EventHandler(this.btnAddModelo_Click);
            // 
            // btnCancelarModelo
            // 
            this.btnCancelarModelo.Location = new System.Drawing.Point(169, 216);
            this.btnCancelarModelo.Name = "btnCancelarModelo";
            this.btnCancelarModelo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarModelo.TabIndex = 3;
            this.btnCancelarModelo.Text = "Cancelar";
            this.btnCancelarModelo.UseVisualStyleBackColor = true;
            this.btnCancelarModelo.Click += new System.EventHandler(this.btnCancelarModelo_Click);
            // 
            // lbErros
            // 
            this.lbErros.AutoSize = true;
            this.lbErros.Location = new System.Drawing.Point(13, 170);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(0, 13);
            this.lbErros.TabIndex = 4;
            // 
            // AddModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbErros);
            this.Controls.Add(this.btnCancelarModelo);
            this.Controls.Add(this.btnAddModelo);
            this.Controls.Add(this.txbAddModelo);
            this.Controls.Add(this.label1);
            this.Name = "AddModelo";
            this.Text = "Adicionar modelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAddModelo;
        private System.Windows.Forms.Button btnAddModelo;
        private System.Windows.Forms.Button btnCancelarModelo;
        private System.Windows.Forms.Label lbErros;
    }
}