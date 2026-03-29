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
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCategoria.Text) || string.IsNullOrEmpty(txtPreco.Text) || string.IsNullOrEmpty(txtQuantidade.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios");
                return;
            }

            List<Produto> listaProdutos;

            if (File.Exists("produtos.json"))
            {
                string json = File.ReadAllText("produtos.json");
                listaProdutos = JsonSerializer.Deserialize<List<Produto>>(json);
            }
            else
            {
                listaProdutos = new List<Produto>();
            }

            var produtoAdicionado = new Produto()
            {
                Nome = txtNome.Text,
                Categoria = txtCategoria.Text,
                Preco = decimal.Parse(txtPreco.Text),
                Quantidade = int.Parse(txtQuantidade.Text)
            };

            listaProdutos.Add(produtoAdicionado);

            string novoJson = JsonSerializer.Serialize(listaProdutos);
            File.WriteAllText("produtos.json", novoJson);

            MessageBox.Show("Produto cadastrado");

            txtNome.Clear();
            txtCategoria.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();

            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = listaProdutos;
        }
    }
}
