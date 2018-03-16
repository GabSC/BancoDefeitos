namespace BancoDeDefeitos.View
{
    partial class AdicionarMarca
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
            this.txbAddMarca = new System.Windows.Forms.TextBox();
            this.btnSalvarMarca = new System.Windows.Forms.Button();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.lbErros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // txbAddMarca
            // 
            this.txbAddMarca.Location = new System.Drawing.Point(54, 103);
            this.txbAddMarca.Name = "txbAddMarca";
            this.txbAddMarca.Size = new System.Drawing.Size(194, 20);
            this.txbAddMarca.TabIndex = 1;
            // 
            // btnSalvarMarca
            // 
            this.btnSalvarMarca.Location = new System.Drawing.Point(54, 216);
            this.btnSalvarMarca.Name = "btnSalvarMarca";
            this.btnSalvarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarMarca.TabIndex = 2;
            this.btnSalvarMarca.Text = "Salvar";
            this.btnSalvarMarca.UseVisualStyleBackColor = true;
            this.btnSalvarMarca.Click += new System.EventHandler(this.btnSalvarMarca_Click);
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.Location = new System.Drawing.Point(164, 216);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMarca.TabIndex = 3;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = true;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // lbErros
            // 
            this.lbErros.AutoSize = true;
            this.lbErros.Location = new System.Drawing.Point(13, 163);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(0, 13);
            this.lbErros.TabIndex = 4;
            // 
            // AdicionarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbErros);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.btnSalvarMarca);
            this.Controls.Add(this.txbAddMarca);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarMarca";
            this.Text = "Adicionar marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAddMarca;
        private System.Windows.Forms.Button btnSalvarMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.Label lbErros;
    }
}