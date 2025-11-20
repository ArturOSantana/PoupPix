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
            this.cofreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarGastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.addgastos.Size = new System.Drawing.Size(57, 20);
            this.addgastos.Text = "Receita";
            // 
            // cofreToolStripMenuItem
            // 
            this.cofreToolStripMenuItem.Name = "cofreToolStripMenuItem";
            this.cofreToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.cofreToolStripMenuItem.Text = "Cofre";
            // 
            // gastoToolStripMenuItem
            // 
            this.gastoToolStripMenuItem.Name = "gastoToolStripMenuItem";
            this.gastoToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.gastoToolStripMenuItem.Text = "Gasto";
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
            // adicionarGastoToolStripMenuItem
            // 
            this.adicionarGastoToolStripMenuItem.Name = "adicionarGastoToolStripMenuItem";
            this.adicionarGastoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarGastoToolStripMenuItem.Text = "Adicionar Gasto";
            this.adicionarGastoToolStripMenuItem.Click += new System.EventHandler(this.adicionarGastoToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
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
    }
}