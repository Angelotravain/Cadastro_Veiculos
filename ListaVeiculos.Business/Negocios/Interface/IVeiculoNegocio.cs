﻿namespace ListaVeiculos.Business.Negocios.Interface
{
    public interface IVeiculoNegocio
    {
        IEnumerable<Veiculo> BuscarVeiculosPorFiltro(string placa = "", string chassi = "", string marca = "", string modelo = "", int anoFabricacao = 0, int anoModelo = 0);
    }
}
