using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVeiculos.Views.Utils
{
    public static class Url
    {
        public static string UrlMarcasVeiculos() { return "https://parallelum.com.br/fipe/api/v1/carros/marcas"; }

        public static string UrlModeloVeiculo(string codigoMarca) { return $"https://parallelum.com.br/fipe/api/v1/carros/marcas/{codigoMarca}/modelos"; }

        public static string UrlLogin() { return ""; }
    }
}
