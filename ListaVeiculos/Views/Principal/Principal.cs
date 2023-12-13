using ListaVeiculos.Views.Views.Cadastro;
using ListaVeiculos.Views.Views.Configuracoes;
using ListaVeiculos.Views.Views.Filtro;

namespace ListaVeiculos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
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

        private void filtorDeVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmFiltrarVeiculo>();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmSobre();
            frm.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Realmente sair do sistema?", "Sair do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.Yes)
            {
                Dispose();
                Application.Exit();
            }
        }

        private void cadastroDeVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmFiltrarVeiculo>();
        }

        private void cadastroDeUsuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmCadastroUsuario>();
        }
    }
}