using ListaVeiculos.Data;
using ListaVeiculosData.Crud.Interface;
using ListaVeiculosData.Repository.Interface;

namespace ListaVeiculosData.Repository
{
    public class VeiculoRepositorio : IVeiculoRepositorio
    {
        private Contexto _context;
        private readonly ICrudGenerico _crudGenerico;
        private const string _retornoSalvar = "Veículo salvo com sucesso!";
        private const string _retornoEditar = "Veículo editado com sucesso!";
        private const string _retornoExcluir = "Veículo excluido com sucesso!";
        public VeiculoRepositorio(Contexto context, ICrudGenerico crudGenerico)
        {
            _context = context;
            _crudGenerico = crudGenerico;
        }

        public Veiculo BuscarVeiculoPorId(int Id)
        {
            return _context.Veiculos.FirstOrDefault(v => v.Id == Id);
        }
        public IEnumerable<Veiculo> FiltrarVeiculoPorParametros(string placa = "", string chassi = "", string marca = "", string modelo = "", int anoFabricacao = 0, int anoModelo = 0)
        {
            var query = _context.Veiculos.AsQueryable();

            if (!string.IsNullOrEmpty(placa))
                query = query.Where(v => v.Placa.Contains(placa));

            if (!string.IsNullOrEmpty(chassi))
                query = query.Where(v => v.Chassi == chassi);

            if (!string.IsNullOrEmpty(marca))
                query = query.Where(v => v.Marca.Contains(marca));

            if (!string.IsNullOrEmpty(modelo))
                query = query.Where(v => v.Modelo.Contains(modelo));

            if (anoFabricacao != 0 && anoModelo != 0)
            {
                query = query.Where(v => v.AnoFabricacao >= anoFabricacao && v.AnoModelo <= anoModelo);
            }
            else
            {
                if (anoFabricacao != 0)
                    query = query.Where(v => v.AnoFabricacao == anoFabricacao);

                if (anoModelo != 0)
                    query = query.Where(v => v.AnoModelo == anoModelo);
            }
            return query.ToList();
        }

        public string SalvarEditarVeiculo(Veiculo veiculo)
        {
            var retorno = "";
            if (veiculo.Id != 0)
            {
                _crudGenerico.Editar<Veiculo>(veiculo, veiculo.Id);
                return _retornoSalvar;
            }
            else
            {
                _crudGenerico.Salvar<Veiculo>(veiculo);
                return _retornoEditar;
            }
        }
        public string ExcluirVeiculo(int id)
        {
            _crudGenerico.Excluir<Veiculo>(id);
            return _retornoExcluir;
        }
    }
}
