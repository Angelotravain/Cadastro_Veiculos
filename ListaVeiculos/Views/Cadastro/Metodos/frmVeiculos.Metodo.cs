namespace ListaVeiculos.Views.Views.Cadastro.Metods
{
    internal static class frmVeiculos
    {
        public static List<ModeloDto> AgruparDadosModeloEAno(List<AnoDto> anoEntrada, List<ModeloDto> modeloEntrada)
        {
            var listaRetorno = new List<ModeloDto>();
            foreach (var ano in anoEntrada)
            {
                if (Convert.ToInt32(ano.Codigo.Substring(0, 4)) < DateTime.Now.AddYears(1).Year)
                {
                    foreach (var modelo in modeloEntrada)
                    {
                        var modeloSaida = new ModeloDto();
                        modeloSaida.Nome = modelo.Nome + " - " + ano.Nome;

                        listaRetorno.Add(modeloSaida);
                    }
                }
            }
            return listaRetorno;
        }

        public static string ObterQuatroDigitosAposHifen(string input)
        {
            int indiceHifen = input.IndexOf("- ");
            if (indiceHifen != -1 && indiceHifen + 2 < input.Length)
            {
                return input.Substring(indiceHifen + 2, 4);
            }
            else
            {
                return string.Empty;
            }
        }
        public static bool ValidarChassi(string numeroChassi)
        {
            if (numeroChassi.Length != 17)
                return true;

            return false;
        }
    }
}
