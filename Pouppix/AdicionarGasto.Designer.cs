namespace Pouppix
{
    partial class AdicionarGasto
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNomegasto = new System.Windows.Forms.Label();
            this.lblValorGasto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGasto = new System.Windows.Forms.DateTimePicker();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.tableUpdateStatementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packetBitConverterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtValorGasto = new System.Windows.Forms.TextBox();
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.txtvaloraux = new System.Windows.Forms.Label();
            this.lblvaloraux2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableUpdateStatementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetBitConverterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adiconar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNomegasto
            // 
            this.lblNomegasto.AutoSize = true;
            this.lblNomegasto.Location = new System.Drawing.Point(234, 86);
            this.lblNomegasto.Name = "lblNomegasto";
            this.lblNomegasto.Size = new System.Drawing.Size(81, 13);
            this.lblNomegasto.TabIndex = 1;
            this.lblNomegasto.Text = "Nome do Gasto";
            // 
            // lblValorGasto
            // 
            this.lblValorGasto.AutoSize = true;
            this.lblValorGasto.Location = new System.Drawing.Point(234, 111);
            this.lblValorGasto.Name = "lblValorGasto";
            this.lblValorGasto.Size = new System.Drawing.Size(31, 13);
            this.lblValorGasto.TabIndex = 2;
            this.lblValorGasto.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data Realizada";
            // 
            // dataGasto
            // 
            this.dataGasto.Location = new System.Drawing.Point(320, 132);
            this.dataGasto.Name = "dataGasto";
            this.dataGasto.Size = new System.Drawing.Size(200, 20);
            this.dataGasto.TabIndex = 4;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(320, 158);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 5;
            this.comboBox.Tag = "";
            // 
            // tableUpdateStatementBindingSource
            // 
            this.tableUpdateStatementBindingSource.DataSource = typeof(MySqlX.XDevAPI.Relational.TableUpdateStatement);
            // 
            // packetBitConverterBindingSource
            // 
            this.packetBitConverterBindingSource.DataSource = typeof(MySql.Data.PacketBitConverter);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(234, 161);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(74, 13);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo de Gasto";
            // 
            // txtValorGasto
            // 
            this.txtValorGasto.Location = new System.Drawing.Point(320, 106);
            this.txtValorGasto.Name = "txtValorGasto";
            this.txtValorGasto.Size = new System.Drawing.Size(100, 20);
            this.txtValorGasto.TabIndex = 7;
            // 
            // txtGasto
            // 
            this.txtGasto.Location = new System.Drawing.Point(320, 80);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.Size = new System.Drawing.Size(100, 20);
            this.txtGasto.TabIndex = 8;
            // 
            // txtvaloraux
            // 
            this.txtvaloraux.AutoSize = true;
            this.txtvaloraux.Location = new System.Drawing.Point(294, 109);
            this.txtvaloraux.Name = "txtvaloraux";
            this.txtvaloraux.Size = new System.Drawing.Size(21, 13);
            this.txtvaloraux.TabIndex = 9;
            this.txtvaloraux.Text = "R$";
            // 
            // lblvaloraux2
            // 
            this.lblvaloraux2.AutoSize = true;
            this.lblvaloraux2.Location = new System.Drawing.Point(426, 109);
            this.lblvaloraux2.Name = "lblvaloraux2";
            this.lblvaloraux2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblvaloraux2.Size = new System.Drawing.Size(22, 13);
            this.lblvaloraux2.TabIndex = 10;
            this.lblvaloraux2.Text = ",00";
            // 
            // AdicionarGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblvaloraux2);
            this.Controls.Add(this.txtvaloraux);
            this.Controls.Add(this.txtGasto);
            this.Controls.Add(this.txtValorGasto);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.dataGasto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValorGasto);
            this.Controls.Add(this.lblNomegasto);
            this.Controls.Add(this.button1);
            this.Name = "AdicionarGasto";
            this.Text = "AdicionarGasto";
            ((System.ComponentModel.ISupportInitialize)(this.tableUpdateStatementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetBitConverterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNomegasto;
        private System.Windows.Forms.Label lblValorGasto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dataGasto;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.BindingSource tableUpdateStatementBindingSource;
        private System.Windows.Forms.BindingSource packetBitConverterBindingSource;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtValorGasto;
        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.Label txtvaloraux;
        private System.Windows.Forms.Label lblvaloraux2;
    }
}