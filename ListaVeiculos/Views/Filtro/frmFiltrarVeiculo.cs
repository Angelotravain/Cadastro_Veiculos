using ListaVeiculos.Business.Dto;
using ListaVeiculos.Business.Negocios.Interface;
using ListaVeiculos.Views.Container;
using ListaVeiculos.Views.Utils;
using ListaVeiculos.Views.Views.Cadastro;
using Ninject;
using System.Globalization;

namespace ListaVeiculos.Views.Views.Filtro
{
    public partial class frmFiltrarVeiculo : Form
    {
        private readonly IVeiculoNegocio _negocio;
        public VeiculoDto VeiculoSelecionado { get; set; }

        [Inject]
        public frmFiltrarVeiculo(IVeiculoNegocio negocio)
        {
            _negocio = negocio;
            InitializeComponent();

        }

        private void frmFiltrarVeiculo_Load(object sender, EventArgs e)
        {
            PreencherGridVeiculo();
            Comuns.ajustarGrid(gridVeiculo);
        }

        private void btnNovoVeiculo_Click(object sender, EventArgs e)
        {
            var frm = FormResolve.Resolve<frmCadastroVeiculo>();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja realmente sair?", "Sair do filtro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.Yes)
            {
                Dispose();
            }
        }

        public void PreencherGridVeiculo(string placa = "", string chassi = "", string marca = "", string modelo = "", int anoFabricacao = 0, int anoModelo = 0)
        {
            var veiculos = _negocio.BuscarVeiculosPorFiltro(placa, chassi, marca, modelo, anoFabricacao, anoModelo);
            foreach (var veiculo in veiculos)
            {
                veiculo.Modelo = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(veiculo.Modelo.ToLower());
            }

            gridVeiculo.DataSource = veiculos.Select(p => new
            {
                Código = p.Id,
                Nome = p.Modelo,
                Modelo = p.AnoModelo,
                Valor_venda = p.ValorVenda
            }).ToList();

            gridVeiculo.Columns["Código"].Visible = false;
        }

        private void gridVeiculo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridVeiculo.Rows[e.RowIndex];
                VeiculoSelecionado = _negocio.BuscarVeiculoPorId((int)row.Cells["Código"].Value);
                if (VeiculoSelecionado != null)
                {
                    var frm = FormResolve.Resolve<frmCadastroVeiculo>();
                    frm.VeiculoDeEntrada = VeiculoSelecionado;
                    frm.ShowDialog();
                }

            }
        }

        private void btnPesquisarVeiculo_Click(object sender, EventArgs e)
        {
            if (dtAnoDeFabricacao.Value.Year > dtAnoModelo.Value.Year)
                MessageBox.Show("Ano de fabricação não pode ser maior que o ano do modelo!", "Validação de data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                PreencherGridVeiculo(txtPlaca.Text, txtChassi.Text, txtMarca.Text, txtModelo.Text, dtAnoDeFabricacao.Value.Year, dtAnoModelo.Value.Year);
        }
    }
}
