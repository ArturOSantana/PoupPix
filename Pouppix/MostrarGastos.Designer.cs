namespace Pouppix
{
    partial class MostrarGastos
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
            this.mySqlDataReaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mySqlDataReaderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mySqlDataReaderBindingSource
            // 
            this.mySqlDataReaderBindingSource.DataSource = typeof(MySql.Data.MySqlClient.MySqlDataReader);
            // 
            // MostrarGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MostrarGastos";
            this.Text = "MostrarGastos";
            ((System.ComponentModel.ISupportInitialize)(this.mySqlDataReaderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource mySqlDataReaderBindingSource;
    }
}