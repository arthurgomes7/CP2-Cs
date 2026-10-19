namespace LojaInstrumentos.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnVenda_Click(object? sender, EventArgs e)
        {
            using var form = new VendaForm();
            form.ShowDialog(this);
        }

        private void btnRelatorio_Click(object? sender, EventArgs e)
        {
            using var form = new RelatorioForm();
            form.ShowDialog(this);
        }

        private void btnSair_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
