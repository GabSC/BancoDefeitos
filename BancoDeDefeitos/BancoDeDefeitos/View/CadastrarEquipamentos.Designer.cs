namespace BancoDeDefeitos.View
{
    partial class CadastrarEquipamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarEquipamentos));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.btnAddMarca = new System.Windows.Forms.Button();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddModelo = new System.Windows.Forms.Button();
            this.cbxModelo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSintoma = new System.Windows.Forms.TextBox();
            this.txbOBS = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbStatusMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(70, 27);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxMarca.TabIndex = 1;
            // 
            // btnAddMarca
            // 
            this.btnAddMarca.Location = new System.Drawing.Point(202, 25);
            this.btnAddMarca.Name = "btnAddMarca";
            this.btnAddMarca.Size = new System.Drawing.Size(24, 23);
            this.btnAddMarca.TabIndex = 2;
            this.btnAddMarca.Text = "+";
            this.btnAddMarca.UseVisualStyleBackColor = true;
            this.btnAddMarca.Click += new System.EventHandler(this.btnAddMarca_Click);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Location = new System.Drawing.Point(202, 78);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(24, 23);
            this.btnAddProduto.TabIndex = 5;
            this.btnAddProduto.Text = "+";
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // cbxProduto
            // 
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(70, 80);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(121, 21);
            this.cbxProduto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produto:";
            // 
            // btnAddModelo
            // 
            this.btnAddModelo.Location = new System.Drawing.Point(202, 128);
            this.btnAddModelo.Name = "btnAddModelo";
            this.btnAddModelo.Size = new System.Drawing.Size(24, 23);
            this.btnAddModelo.TabIndex = 8;
            this.btnAddModelo.Text = "+";
            this.btnAddModelo.UseVisualStyleBackColor = true;
            this.btnAddModelo.Click += new System.EventHandler(this.btnAddModelo_Click);
            // 
            // cbxModelo
            // 
            this.cbxModelo.FormattingEnabled = true;
            this.cbxModelo.Location = new System.Drawing.Point(70, 130);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(121, 21);
            this.cbxModelo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sintoma/Defeito:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Observação:";
            // 
            // txbSintoma
            // 
            this.txbSintoma.Location = new System.Drawing.Point(524, 35);
            this.txbSintoma.Multiline = true;
            this.txbSintoma.Name = "txbSintoma";
            this.txbSintoma.Size = new System.Drawing.Size(340, 80);
            this.txbSintoma.TabIndex = 11;
            // 
            // txbOBS
            // 
            this.txbOBS.Location = new System.Drawing.Point(524, 130);
            this.txbOBS.Multiline = true;
            this.txbOBS.Name = "txbOBS";
            this.txbOBS.Size = new System.Drawing.Size(340, 80);
            this.txbOBS.TabIndex = 12;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(297, 214);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(434, 214);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(26, 196);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(40, 13);
            this.lbStatus.TabIndex = 15;
            this.lbStatus.Text = "Status:";
            // 
            // lbStatusMsg
            // 
            this.lbStatusMsg.AutoSize = true;
            this.lbStatusMsg.Location = new System.Drawing.Point(70, 196);
            this.lbStatusMsg.Name = "lbStatusMsg";
            this.lbStatusMsg.Size = new System.Drawing.Size(0, 13);
            this.lbStatusMsg.TabIndex = 16;
            // 
            // CadastrarEquipamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(876, 265);
            this.Controls.Add(this.lbStatusMsg);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txbOBS);
            this.Controls.Add(this.txbSintoma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddModelo);
            this.Controls.Add(this.cbxModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.cbxProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddMarca);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrarEquipamentos";
            this.Text = "Cadastrar Equipamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Button btnAddMarca;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddModelo;
        private System.Windows.Forms.ComboBox cbxModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSintoma;
        private System.Windows.Forms.TextBox txbOBS;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbStatusMsg;
    }
}