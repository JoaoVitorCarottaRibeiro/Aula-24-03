using System.Text.Json;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtQuantidade.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios");
                return;
            }

            var listaProdutos = new List<Produto>();

            var produtoAdicionado = new Produto()
            {
                Nome = txtNome.Text,
                Categoria = txtQuantidade.Text,
                Preco = decimal.Parse(txtPreco.Text),
                Quantidade = int.Parse(txtQuantidade.Text)
            };

            listaProdutos.Add(produtoAdicionado);

            if (!File.Exists("dgvProdutos.json"))
            {
                string json = JsonSerializer.Serialize(listaProdutos);
                File.WriteAllText("produtos.json", json);
            }
            else
            {
                string json = File.ReadAllText("produtos.json");
                var listaAntiga = JsonSerializer.Deserialize<List<Produto>>(json);
                listaProdutos = listaAntiga;

                listaProdutos.Add(produtoAdicionado);
                json = JsonSerializer.Serialize(listaProdutos);
                File.WriteAllText("produtos.json", json);

            }

            MessageBox.Show("Produto cadastrado");
            txtNome.Text = string.Empty;
            txtCategoria.Text = string.Empty;

            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = listaProdutos;

        }
    }
}
