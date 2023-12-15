using Newtonsoft.Json;

namespace ListaVeiculos.Views.Utils
{
    public static class Comuns
    {
        public static void ConfigureAutoComplete<T>(TextBox textBox, List<T> listaDados)
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();

            foreach (var item in listaDados)
            {
                var propertyName = item.GetType().GetProperty("Nome");
                if (propertyName != null)
                {
                    var valueName = propertyName.GetValue(item)?.ToString();
                    if (!string.IsNullOrEmpty(valueName))
                        autoCompleteCollection.Add(valueName);
                }
            }

            textBox.Text = string.Empty;
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
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<T> dadosRecuperados = JsonConvert.DeserializeObject<List<T>>(responseBody);
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
                    string responseBody = await response.Content.ReadAsStringAsync();
                    T dadosRecuperados = JsonConvert.DeserializeObject<T>(responseBody);
                    return dadosRecuperados;
                }
            }

            return default(T);
        }
        public static void ajustarGrid(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.Dock = DockStyle.Fill;
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.ReadOnly = true;
            grid.DefaultCellStyle.SelectionBackColor = SystemColors.GradientActiveCaption;
            grid.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid.BackgroundColor = SystemColors.Window;
            grid.BorderStyle = BorderStyle.None;
        }
    }
}
