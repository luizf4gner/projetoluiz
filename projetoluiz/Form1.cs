namespace projetoluiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormCriarproduto fcp = new FormCriarproduto();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                string textoProduto = $"{fcp.nomeProduto},({fcp.nomeFabricante}) preço de compra [R$ {fcp.precoCompra}] preço de venda [R$ {fcp.PrecoVenda}]";
                listBox1.Items.Add(textoProduto);
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
