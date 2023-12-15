using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVeiculos.Views.Utils
{
    public static class Comuns
    {
        public static void ConfigureAutoComplete<T>(TextBox textBox, List<T> listaDados, string parametroInicial = "")
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();

            foreach (var item in listaDados)
            {
                var propriedadeNome = item.GetType().GetProperty("Nome");
                if (propriedadeNome != null)
                {
                    var valorNome = propriedadeNome.GetValue(item)?.ToString();
                    if (!string.IsNullOrEmpty(valorNome))
                        autoCompleteCollection.Add(valorNome);
                }
            }

            textBox.Text = parametroInicial;
            textBox.AutoCompleteCustomSource = autoCompleteCollection;
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }


        public async static Task<List<T>> ListarDados<T>(string apiUrl)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string resposta = await response.Content.ReadAsStringAsync();
                    List<T> dadosRecuperados = JsonConvert.DeserializeObject<List<T>>(resposta);
                    return dadosRecuperados;
                }
            }

            return null;
        }
        public async static Task<T> ListarDadosModelo<T>(string apiUrl)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string resposta = await response.Content.ReadAsStringAsync();
                    T dadosRecuperados = JsonConvert.DeserializeObject<T>(resposta);
                    return dadosRecuperados;
                }
            }

            return default(T);
        }
        public static void AbrirImagem(PictureBox pictureBox)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de imagem (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|Todos os arquivos (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image imagem = Image.FromFile(openFileDialog.FileName);
                        pictureBox.Image = imagem;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível abrir o arquivo. Erro: " + ex.Message);
                    }
                }
            }
        }
    }
}
