using ListaVeiculos.Business.Dto;
using ListaVeiculos.Business.Negocios.Interface;
using ListaVeiculosData.Repository.Interface;

namespace ListaVeiculos.Business.Negocios
{
    public class VeiculoNegocio : IVeiculoNegocio
    {
        private readonly IVeiculoRepositorio _repository;
        public VeiculoNegocio(IVeiculoRepositorio repository)
        {
            _repository = repository;
        }

        public IEnumerable<Veiculo> BuscarVeiculosPorFiltro(string placa = "", string chassi = "", string marca = "", string modelo = "", int anoFabricacao = 0, int anoModelo = 0)
        {
            return _repository.FiltrarVeiculoPorParametros(placa, chassi, marca, modelo, anoFabricacao, anoModelo);
        }

        public VeiculoDto BuscarVeiculoPorId(int Id)
        {
            return MapperVeiculo.MapearVeiculoParaDto(_repository.BuscarVeiculoPorId(Id));
        }

        public string SalvarEditarVeiculo(VeiculoDto veiculo)
        {
            return _repository.SalvarEditarVeiculo(MapperVeiculo.MapearVeiculoParaEntidade(veiculo));
        }
        public string ExcluirVeiculo(int Id)
        {
            return _repository.ExcluirVeiculo(Id);
        }
    }
}
