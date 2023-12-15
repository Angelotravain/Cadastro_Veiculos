using System.Text;

namespace ListaVeiculos.Views.Views.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private async void btnLogar_Click(object sender, EventArgs e)
        {
            string apiUrl = "https://test-api-y04b.onrender.com/signIn";
            string username = txtLogin.Text;
            string password = txtSenha.Text;

            btnLogar.Enabled = false;
            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent($"{{\"user\":\"{username}\", \"password\":\"{password}\"}}", Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        //MessageBox.Show($"Resposta bem-sucedida: {responseBody}"); // mandar para o banco salvar o login 
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show($"Usuário e/ou senha inválido!");
                        btnLogar.Enabled = true;
                        txtLogin.Text = string.Empty;
                        txtSenha.Text = string.Empty;
                        txtLogin.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
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
