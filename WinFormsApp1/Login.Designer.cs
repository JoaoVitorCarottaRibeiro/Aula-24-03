namespace WinFormsApp1
{
    partial class Login
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
            lblEmail = new Label();
            lblSenha = new Label();
            lnkCadastrar = new LinkLabel();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(115, 54);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(115, 90);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha";
            // 
            // lnkCadastrar
            // 
            lnkCadastrar.AutoSize = true;
            lnkCadastrar.Location = new Point(219, 159);
            lnkCadastrar.Name = "lnkCadastrar";
            lnkCadastrar.Size = new Size(57, 15);
            lnkCadastrar.TabIndex = 2;
            lnkCadastrar.TabStop = true;
            lnkCadastrar.Text = "Cadastrar";
            lnkCadastrar.LinkClicked += lnkCadastrar_LinkClicked;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(176, 51);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(176, 87);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(115, 155);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(lnkCadastrar);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblSenha;
        private LinkLabel lnkCadastrar;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btnLogin;
    }
}