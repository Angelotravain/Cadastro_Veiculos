using ListaVeiculos.Views.Utils;
using System.Text;

namespace ListaVeiculos.Views.Views.Login
{
    public partial class frmLogin : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private async void btnLogar_Click(object sender, EventArgs e)
        {
            btnLogar.Enabled = false;

            var content = new StringContent($"{{\"user\":\"{txtLogin.Text}\", \"password\":\"{txtSenha.Text}\"}}", Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync(Url.UrlLogin(), content).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha inválido!");
                    ResetLoginForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
            finally
            {
                btnLogar.Enabled = true;
            }
        }

        private void ResetLoginForm()
        {
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtLogin.Focus();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Deseja realmente fechar o sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}
