using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lnkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Preencha email e senha para cadastrar");
                return;
            }

            List<Usuario> usuarios;

            if (File.Exists("usuarios.json"))
            {
                string json = File.ReadAllText("usuarios.json");
                usuarios = JsonSerializer.Deserialize<List<Usuario>>(json);
            }
            else
            {
                usuarios = new List<Usuario>();
            }

            if (usuarios.Any(u => u.Email == txtEmail.Text))
            {
                MessageBox.Show("Usuário já já cadastrado");
                return;
            }

            usuarios.Add(new Usuario
            {
                Email = txtEmail.Text,
                Senha = txtSenha.Text
            });

            string novoJson = JsonSerializer.Serialize(usuarios);
            File.WriteAllText("usuarios.json", novoJson);

            MessageBox.Show("Cadastro realizado com sucesso");


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (!File.Exists("usuarios.json"))
            {
                MessageBox.Show("Nenhum usuário cadastrado. Faça o cadastro primeiro");
                return;
            }

            string json = File.ReadAllText("usuarios.json");

            var usuarios = JsonSerializer.Deserialize<List<Usuario>>(json);

            var usuario = usuarios.FirstOrDefault(u =>
            u.Email == txtEmail.Text && u.Senha == txtSenha.Text);

            if (usuario != null) {

                this.Hide();
                var formPrincipal = new Form1();
                formPrincipal.ShowDialog();
                this.Close();
            }
            else {

                MessageBox.Show("Email ou senha inválidos");

            }

        }
    }
}
