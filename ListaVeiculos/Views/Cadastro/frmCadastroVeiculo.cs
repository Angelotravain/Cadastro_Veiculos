using ListaVeiculos.Business.Dto;
using ListaVeiculos.Business.Negocios.Interface;
using ListaVeiculos.Views.Dto;
using ListaVeiculos.Views.Utils;
using ListaVeiculos.Views.Views.Cadastro.Metods;
using Ninject;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ListaVeiculos.Views.Views.Cadastro
{
    public partial class frmCadastroVeiculo : Form
    {
        private const string _valorInicialCampos = "R$ 0,00";
        private List<MarcaDto> _listaEntradaMarca { get; set; }

        public VeiculoDto VeiculoDeEntrada { get; set; }
        private DadosDto _dadosModelo { get; set; }
        private IVeiculoNegocio _veiculoNegocio { get; set; }

        [Inject]
        public frmCadastroVeiculo(IVeiculoNegocio veiculoNegocio)
        {
            _veiculoNegocio = veiculoNegocio;
            InitializeComponent();
        }

        private async void frmCadastroVeiculo_Load(object sender, EventArgs e)
        {
            txtValorFipe.TextChanged += FormatarValorFipe;
            txtValorVenda.TextChanged += FormatarValorVenda;

            _listaEntradaMarca = await Comuns.ListarDados<MarcaDto>(Url.UrlMarcasVeiculos());
            Comuns.ConfigureAutoComplete(txtMarca, _listaEntradaMarca);
            PreencherCampoModelo(VeiculoDeEntrada);
            PreencherEValidarCampos(VeiculoDeEntrada);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (frmVeiculos.ValidarChassi(txtChassi.Text))
                MessageBox.Show("Número de chassi inválido!", "Validação de Chassi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtValorFipe.Text.Equals(_valorInicialCampos) || txtValorVenda.Equals(_valorInicialCampos))
                MessageBox.Show("Para salvar um registro preencha valor FIPE e valor de venda!", "Validação de Valores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtMarca.Text == string.Empty)
                MessageBox.Show("Para salvar um registro insira a marca do vaículo!", "Validação de marcas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                PreencherCamposEditarSalvar();
                MessageBox.Show(_veiculoNegocio.SalvarEditarVeiculo(VeiculoDeEntrada), "Editado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (frmVeiculos.ValidarChassi(txtChassi.Text))
                MessageBox.Show("Número de chassi inválido!", "Validação de Chassi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtValorFipe.Text.Equals(_valorInicialCampos) || txtValorVenda.Equals(_valorInicialCampos))
                MessageBox.Show("Para salvar um registro preencha valor FIPE e valor de venda!", "Validação de Valores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtMarca.Text == string.Empty)
                MessageBox.Show("Para salvar um registro insira a marca do vaículo!", "Validação de marcas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult confirm = MessageBox.Show("Deseja Realmente editar esse registro?", "editar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm == DialogResult.Yes)
                {
                    PreencherCamposEditarSalvar();
                    MessageBox.Show(_veiculoNegocio.SalvarEditarVeiculo(VeiculoDeEntrada), "Editado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Dispose();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Realmente excluir esse registro?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.Yes)
            {
                MessageBox.Show(_veiculoNegocio.ExcluirVeiculo(VeiculoDeEntrada.Id), "Editado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Realmente cancelar a ação?", "cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.Yes)
            {
                Dispose();
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

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            VeiculoDeEntrada.Marca = txtMarca.Text;
            PreencherCampoModelo(VeiculoDeEntrada);
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
            string value = Regex.Replace(txtValorFipe.Text, @"[^\d]", string.Empty);

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
            string value = Regex.Replace(txtValorVenda.Text, @"[^\d]", string.Empty);

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
        private async void PreencherCampoModelo(VeiculoDto veiculoEntrada)
        {
            var marcaSelecionada = _listaEntradaMarca.FirstOrDefault(m => m.Nome.Equals(txtMarca.Text));

            _dadosModelo = await Comuns.ListarDadosModelo<DadosDto>(Url.UrlModeloVeiculo(marcaSelecionada?.Codigo.ToString()));

            if (_dadosModelo != null)
            {
                List<ModeloDto> modelos = _dadosModelo.Modelos;
                List<AnoDto> anos = _dadosModelo.Anos;
                if (veiculoEntrada != null)
                    PreencherEValidarCampos(veiculoEntrada);

                Comuns.ConfigureAutoComplete(txtModelo, frmVeiculos.AgruparDadosModeloEAno(anos, modelos));

            }
        }

        private void PreencherEValidarCampos(VeiculoDto veiculoEntrada)
        {
            if (veiculoEntrada != null)
            {
                txtChassi.Text = veiculoEntrada.Chassi;
                txtMarca.Text = veiculoEntrada.Marca;
                txtModelo.Text = veiculoEntrada.Modelo;
                txtObservacoes.Text = veiculoEntrada.Observacoes;
                txtPlaca.Text = veiculoEntrada.Placa;
                dtAnoDeFabricacao.Value = new DateTime(veiculoEntrada.AnoFabricacao, 01, 01);
                dtAnoModelo.Value = new DateTime(veiculoEntrada.AnoModelo, 01, 01);
                txtValorFipe.Text = veiculoEntrada.ValorTabelaFipe.ToString("C");
                txtValorVenda.Text = veiculoEntrada.ValorVenda.ToString("C");

                btnSalvar.Visible = false;
                btnCancelar.Visible = false;
                btnSair.Visible = true;
                btnExcluir.Visible = true;
                btnEditar.Visible = true;
            }
            else
            {
                btnSalvar.Visible = true;
                btnCancelar.Visible = true;
                btnSair.Visible = true;
                btnExcluir.Visible = false;
                btnEditar.Visible = false;
            }

        }
        #endregion

        private void PreencherCamposEditarSalvar()
        {
            if (VeiculoDeEntrada == null)
                VeiculoDeEntrada = new VeiculoDto();

            VeiculoDeEntrada.ValorVenda = Convert.ToDecimal(txtValorVenda.Text.Replace("R$", string.Empty));
            VeiculoDeEntrada.ValorTabelaFipe = Convert.ToDecimal(txtValorFipe.Text.Replace("R$", string.Empty));
            VeiculoDeEntrada.Marca = txtMarca.Text;
            VeiculoDeEntrada.Chassi = txtChassi.Text;
            VeiculoDeEntrada.Modelo = txtModelo.Text;
            VeiculoDeEntrada.DataCadastro = DateTime.Now;
            VeiculoDeEntrada.Observacoes = txtObservacoes.Text;
            VeiculoDeEntrada.Placa = txtPlaca.Text;
            VeiculoDeEntrada.AnoFabricacao = dtAnoDeFabricacao.Value.Year;
            VeiculoDeEntrada.AnoModelo = dtAnoModelo.Value.Year;
        }
    }
}
