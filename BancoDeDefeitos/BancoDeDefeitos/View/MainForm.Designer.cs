﻿namespace BancoDeDefeitos.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarEquipamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarSoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarEquipamentoToolStripMenuItem,
            this.pesquisarSoluçãoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarEquipamentoToolStripMenuItem
            // 
            this.cadastrarEquipamentoToolStripMenuItem.Name = "cadastrarEquipamentoToolStripMenuItem";
            this.cadastrarEquipamentoToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.cadastrarEquipamentoToolStripMenuItem.Text = "Cadastrar Equipamento";
            this.cadastrarEquipamentoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarEquipamentoToolStripMenuItem_Click);
            // 
            // pesquisarSoluçãoToolStripMenuItem
            // 
            this.pesquisarSoluçãoToolStripMenuItem.Name = "pesquisarSoluçãoToolStripMenuItem";
            this.pesquisarSoluçãoToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.pesquisarSoluçãoToolStripMenuItem.Text = "Pesquisar solução";
            this.pesquisarSoluçãoToolStripMenuItem.Click += new System.EventHandler(this.pesquisarSoluçãoToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::BancoDeDefeitos.Properties.Resources.GabsoftEditado;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarEquipamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarSoluçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    }
}