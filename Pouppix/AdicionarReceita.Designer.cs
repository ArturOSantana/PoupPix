namespace Pouppix
{
    partial class AdicionarReceita
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
            this.btnaddReceita = new System.Windows.Forms.Button();
            this.txtNomeReceita = new System.Windows.Forms.TextBox();
            this.txtvalorReceita = new System.Windows.Forms.TextBox();
            this.lblNomeReceita = new System.Windows.Forms.Label();
            this.lblValorGasto = new System.Windows.Forms.Label();
            this.lbldataReceita = new System.Windows.Forms.Label();
            this.dataEntradaReceita = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnaddReceita
            // 
            this.btnaddReceita.Location = new System.Drawing.Point(334, 188);
            this.btnaddReceita.Name = "btnaddReceita";
            this.btnaddReceita.Size = new System.Drawing.Size(123, 24);
            this.btnaddReceita.TabIndex = 0;
            this.btnaddReceita.Text = "Adicionar Receita";
            this.btnaddReceita.UseVisualStyleBackColor = true;
            this.btnaddReceita.Click += new System.EventHandler(this.btnaddReceita_Click);
            // 
            // txtNomeReceita
            // 
            this.txtNomeReceita.Location = new System.Drawing.Point(334, 85);
            this.txtNomeReceita.Name = "txtNomeReceita";
            this.txtNomeReceita.Size = new System.Drawing.Size(100, 20);
            this.txtNomeReceita.TabIndex = 1;
            // 
            // txtvalorReceita
            // 
            this.txtvalorReceita.Location = new System.Drawing.Point(334, 111);
            this.txtvalorReceita.Name = "txtvalorReceita";
            this.txtvalorReceita.Size = new System.Drawing.Size(100, 20);
            this.txtvalorReceita.TabIndex = 2;
            // 
            // lblNomeReceita
            // 
            this.lblNomeReceita.AutoSize = true;
            this.lblNomeReceita.Location = new System.Drawing.Point(226, 88);
            this.lblNomeReceita.Name = "lblNomeReceita";
            this.lblNomeReceita.Size = new System.Drawing.Size(90, 13);
            this.lblNomeReceita.TabIndex = 3;
            this.lblNomeReceita.Text = "Nome da Receita";
            this.lblNomeReceita.UseMnemonic = false;
            // 
            // lblValorGasto
            // 
            this.lblValorGasto.AutoSize = true;
            this.lblValorGasto.Location = new System.Drawing.Point(226, 118);
            this.lblValorGasto.Name = "lblValorGasto";
            this.lblValorGasto.Size = new System.Drawing.Size(86, 13);
            this.lblValorGasto.TabIndex = 4;
            this.lblValorGasto.Text = "Valor da Receita";
            // 
            // lbldataReceita
            // 
            this.lbldataReceita.AutoSize = true;
            this.lbldataReceita.Location = new System.Drawing.Point(189, 146);
            this.lbldataReceita.Name = "lbldataReceita";
            this.lbldataReceita.Size = new System.Drawing.Size(127, 13);
            this.lbldataReceita.TabIndex = 5;
            this.lbldataReceita.Text = "Data da Entrada do Valor";
            // 
            // dataEntradaReceita
            // 
            this.dataEntradaReceita.Location = new System.Drawing.Point(334, 138);
            this.dataEntradaReceita.Name = "dataEntradaReceita";
            this.dataEntradaReceita.Size = new System.Drawing.Size(200, 20);
            this.dataEntradaReceita.TabIndex = 6;
            // 
            // AdicionarReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataEntradaReceita);
            this.Controls.Add(this.lbldataReceita);
            this.Controls.Add(this.lblValorGasto);
            this.Controls.Add(this.lblNomeReceita);
            this.Controls.Add(this.txtvalorReceita);
            this.Controls.Add(this.txtNomeReceita);
            this.Controls.Add(this.btnaddReceita);
            this.Name = "AdicionarReceita";
            this.Text = "AdicionarReceita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddReceita;
        private System.Windows.Forms.TextBox txtNomeReceita;
        private System.Windows.Forms.TextBox txtvalorReceita;
        private System.Windows.Forms.Label lblNomeReceita;
        private System.Windows.Forms.Label lblValorGasto;
        private System.Windows.Forms.Label lbldataReceita;
        private System.Windows.Forms.DateTimePicker dataEntradaReceita;
    }
}