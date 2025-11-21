namespace Pouppix
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addgastos = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarGastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cofreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalReceita = new System.Windows.Forms.Label();
            this.totalGastos = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adicionarReceitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addgastos,
            this.cofreToolStripMenuItem,
            this.gastoToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.objetivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addgastos
            // 
            this.addgastos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarGastoToolStripMenuItem});
            this.addgastos.Name = "addgastos";
            this.addgastos.Size = new System.Drawing.Size(54, 20);
            this.addgastos.Text = "Gastos";
            // 
            // adicionarGastoToolStripMenuItem
            // 
            this.adicionarGastoToolStripMenuItem.Name = "adicionarGastoToolStripMenuItem";
            this.adicionarGastoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.adicionarGastoToolStripMenuItem.Text = "Adicionar Gasto";
            this.adicionarGastoToolStripMenuItem.Click += new System.EventHandler(this.adicionarGastoToolStripMenuItem_Click);
            // 
            // cofreToolStripMenuItem
            // 
            this.cofreToolStripMenuItem.Name = "cofreToolStripMenuItem";
            this.cofreToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.cofreToolStripMenuItem.Text = "Cofre";
            // 
            // gastoToolStripMenuItem
            // 
            this.gastoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarReceitaToolStripMenuItem});
            this.gastoToolStripMenuItem.Name = "gastoToolStripMenuItem";
            this.gastoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.gastoToolStripMenuItem.Text = "Receita";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // objetivoToolStripMenuItem
            // 
            this.objetivoToolStripMenuItem.Name = "objetivoToolStripMenuItem";
            this.objetivoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.objetivoToolStripMenuItem.Text = "Objetivo";
            // 
            // totalReceita
            // 
            this.totalReceita.AutoSize = true;
            this.totalReceita.Location = new System.Drawing.Point(170, 85);
            this.totalReceita.Name = "totalReceita";
            this.totalReceita.Size = new System.Drawing.Size(35, 13);
            this.totalReceita.TabIndex = 1;
            this.totalReceita.Text = "label1";
            // 
            // totalGastos
            // 
            this.totalGastos.AutoSize = true;
            this.totalGastos.Location = new System.Drawing.Point(170, 114);
            this.totalGastos.Name = "totalGastos";
            this.totalGastos.Size = new System.Drawing.Size(35, 13);
            this.totalGastos.TabIndex = 2;
            this.totalGastos.Text = "label1";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(221, 52);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(33, 13);
            this.lblnome.TabIndex = 3;
            this.lblnome.Text = "nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Olá,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "TOTAL DAS RECEITAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TOTAL DOS GASTOS";
            // 
            // adicionarReceitaToolStripMenuItem
            // 
            this.adicionarReceitaToolStripMenuItem.Name = "adicionarReceitaToolStripMenuItem";
            this.adicionarReceitaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarReceitaToolStripMenuItem.Text = "Adicionar Receita";
            this.adicionarReceitaToolStripMenuItem.Click += new System.EventHandler(this.adicionarReceitaToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.totalGastos);
            this.Controls.Add(this.totalReceita);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addgastos;
        private System.Windows.Forms.ToolStripMenuItem cofreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarGastoToolStripMenuItem;
        private System.Windows.Forms.Label totalReceita;
        private System.Windows.Forms.Label totalGastos;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem adicionarReceitaToolStripMenuItem;
    }
}