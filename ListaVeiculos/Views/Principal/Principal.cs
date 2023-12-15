using ListaVeiculos.Views.Container;
using ListaVeiculos.Views.Views.Configuracoes;
using ListaVeiculos.Views.Views.Filtro;
using ListaVeiculos.Views.Views.Login;

namespace ListaVeiculos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            var login = new frmLogin();
            login.ShowDialog();
        }
        private void Principal_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Deseja realmente fechar o sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void pcSair_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Realmente sair do sistema?", "Sair do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.Yes)
            {
                Dispose();
                Application.Exit();
            }
        }

        private void pcSobre_Click(object sender, EventArgs e)
        {
            var frm = new frmSobre();
            frm.ShowDialog();
        }

        private void pcVeiculos_Click(object sender, EventArgs e)
        {
            var frm = FormResolve.Resolve<frmFiltrarVeiculo>();
            frm.ShowDialog();
        }
    }
}