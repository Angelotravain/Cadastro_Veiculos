using ListaVeiculos.Views.Dto;
using ListaVeiculos.Views.Utils;
using ListaVeiculos.Views.Views.Cadastro.Metods;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ListaVeiculos.Views.Views.Cadastro
{
    public partial class frmCadastroVeiculo : Form
    {
        private const string _marcaInicial = "Acura";
        private const string _valorInicialCampos = "R$ 0,00";
        private List<MarcaDto> _listaEntradaMarca { get; set; }
        private DadosDto _dadosModelo { get; set; }
        public frmCadastroVeiculo()
        {
            InitializeComponent();
        }

        private async void frmCadastroVeiculo_Load(object sender, EventArgs e)
        {
            txtValorFipe.TextChanged += FormatarValorFipe;
            txtValorVenda.TextChanged += FormatarValorVenda;

            _listaEntradaMarca = await Comuns.ListarDados<MarcaDto>(Url.UrlMarcasVeiculos());
            Comuns.ConfigureAutoComplete(txtMarca, _listaEntradaMarca, _marcaInicial);
            PreencherCampoModelo();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (frmVeiculos.ValidarChassi(txtChassi.Text))
                MessageBox.Show("Número de chassi inválido!", "Validação de Chassi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtValorFipe.Text.Equals(_valorInicialCampos) || txtValorVenda.Equals(_valorInicialCampos))
                MessageBox.Show("Para salvar um registro preencha valor FIPE e valor de venda!", "Validação de Valores", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void imgVeiculo_Click(object sender, EventArgs e)
        {
            Comuns.AbrirImagem(imgVeiculo);
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            PreencherCampoModelo();
        }

        private void txtModelo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtAnoModelo.Value = new DateTime(Convert.ToInt32(frmVeiculos.ObterQuatroDigitosAposHifen(txtModelo.Text)), 01, 01);
                dtAnoDeFabricacao.Value = new DateTime(Convert.ToInt32(frmVeiculos.ObterQuatroDigitosAposHifen(txtModelo.Text)), 01, 01);
            }
        }
        #region Formatar campos dinheiro
        public void FormatarValorFipe(object sender, EventArgs e)
        {
            string value = Regex.Replace(txtValorFipe.Text, @"[^\d]", "");

            if (decimal.TryParse(value, out decimal amount))
            {
                NumberFormatInfo nfi = CultureInfo.CurrentCulture.NumberFormat;

                string formattedValue = string.Format("{0:C}", (amount / 100));

                txtValorFipe.Text = formattedValue;

                txtValorFipe.SelectionStart = txtValorFipe.Text.Length;
            }
        }

        private void FormatarValorVenda(object sender, EventArgs e)
        {
            string value = Regex.Replace(txtValorVenda.Text, @"[^\d]", "");

            if (decimal.TryParse(value, out decimal amount))
            {
                NumberFormatInfo nfi = CultureInfo.CurrentCulture.NumberFormat;

                string formattedValue = string.Format("{0:C}", (amount / 100));

                txtValorVenda.Text = formattedValue;

                txtValorVenda.SelectionStart = txtValorVenda.Text.Length;
            }
        }
        #endregion

        #region Preencher campo modelo dinamicamente 
        private async void PreencherCampoModelo()
        {
            var marcaSelecionada = _listaEntradaMarca.Where(m => m.Nome.Equals(txtMarca.Text)).First();
            _dadosModelo = await Comuns.ListarDadosModelo<DadosDto>(Url.UrlModeloVeiculo(marcaSelecionada.Codigo.ToString()));
            if (_dadosModelo != null)
            {
                List<ModeloDto> modelos = _dadosModelo.Modelos;
                List<AnoDto> anos = _dadosModelo.Anos;
                Comuns.ConfigureAutoComplete(txtModelo, frmVeiculos.AgruparDadosModeloEAno(anos, modelos));
            }
        }
        #endregion

    }
}
