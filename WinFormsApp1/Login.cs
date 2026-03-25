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

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("usuarios.json");

            var usuarios = JsonSerializer.Deserialize<List<Usuario>>(json);

            var usuario = usuarios.FirstOrDefault(u =>
            u.email == txtEmail.Text && u.senha == txtSenha.Text);

        }
    }
}
