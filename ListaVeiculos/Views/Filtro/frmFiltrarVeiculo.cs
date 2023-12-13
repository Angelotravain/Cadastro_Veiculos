using ListaVeiculos.Views.Views.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaVeiculos.Views.Views.Filtro
{
    public partial class frmFiltrarVeiculo : Form
    {
        public frmFiltrarVeiculo()
        {
            InitializeComponent();
        }

        private void btnNovoVeiculo_Click(object sender, EventArgs e)
        {
            var frm = new frmCadastroVeiculo();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Realmente sair?", "sair do filtro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.Yes)
            {
                Dispose();
            }
        }
    }
}
