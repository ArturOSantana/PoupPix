namespace Pouppix
{
    partial class login
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
            this.lblemailLog = new System.Windows.Forms.Label();
            this.lblsenhaLog = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtloginsenha = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkcadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblemailLog
            // 
            this.lblemailLog.AutoSize = true;
            this.lblemailLog.Location = new System.Drawing.Point(256, 103);
            this.lblemailLog.Name = "lblemailLog";
            this.lblemailLog.Size = new System.Drawing.Size(35, 13);
            this.lblemailLog.TabIndex = 0;
            this.lblemailLog.Text = "E-mail";
            // 
            // lblsenhaLog
            // 
            this.lblsenhaLog.AutoSize = true;
            this.lblsenhaLog.Location = new System.Drawing.Point(256, 130);
            this.lblsenhaLog.Name = "lblsenhaLog";
            this.lblsenhaLog.Size = new System.Drawing.Size(38, 13);
            this.lblsenhaLog.TabIndex = 1;
            this.lblsenhaLog.Text = "Senha";
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(311, 103);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(100, 20);
            this.txtlogin.TabIndex = 2;
            // 
            // txtloginsenha
            // 
            this.txtloginsenha.Location = new System.Drawing.Point(311, 130);
            this.txtloginsenha.Name = "txtloginsenha";
            this.txtloginsenha.Size = new System.Drawing.Size(100, 20);
            this.txtloginsenha.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(259, 177);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkcadastro
            // 
            this.linkcadastro.Location = new System.Drawing.Point(358, 177);
            this.linkcadastro.Name = "linkcadastro";
            this.linkcadastro.Size = new System.Drawing.Size(75, 23);
            this.linkcadastro.TabIndex = 5;
            this.linkcadastro.Text = "Cadastrar-se";
            this.linkcadastro.UseVisualStyleBackColor = true;
            this.linkcadastro.Click += new System.EventHandler(this.linkcadastro_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkcadastro);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtloginsenha);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.lblsenhaLog);
            this.Controls.Add(this.lblemailLog);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemailLog;
        private System.Windows.Forms.Label lblsenhaLog;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtloginsenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button linkcadastro;
    }
}