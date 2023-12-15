using ListaVeiculos.Business.Negocios.Interface;
using ListaVeiculosData.Repository.Interface;

namespace ListaVeiculos.Business.Negocios
{
    internal class VeiculoNegocio : IVeiculoNegocio
    {
        private readonly IVeiculoRepositorio _repository;
        public VeiculoNegocio(IVeiculoRepositorio repository)
        {
            _repository = repository;
        }
        public IEnumerable<Veiculo> BuscarVeiculosPorFiltro(string placa = "", string chassi = "", string marca = "", string modelo = "", int anoFabricacao = 0, int anoModelo = 0)
        {
            if (string.IsNullOrEmpty(placa) && string.IsNullOrEmpty(chassi) && string.IsNullOrEmpty(marca) && string.IsNullOrEmpty(modelo) && anoFabricacao == 0 && anoModelo == 0)
                throw new ArgumentException("Insira algum dos campos para refinar seu filtro!");

            return _repository.FiltrarVeiculoPorParametros(placa, chassi, marca, modelo, anoFabricacao, anoModelo);

        }
    }
}
