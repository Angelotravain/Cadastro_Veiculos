using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaVeiculos.Views.Views.Cadastro
{
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Realmente editar esse registro?", "editar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.Yes)
            {
                // editar registro
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Realmente excluir esse registro?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.Yes)
            {
                // excluir registro
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Realmente cancelar a ação?", "cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.Yes)
            {
                // cancelar ação
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Realmente sair?", "sair do cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
