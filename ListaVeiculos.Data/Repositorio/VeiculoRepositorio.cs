using ListaVeiculos.Data;
using ListaVeiculosData.Repository.Interface;

namespace ListaVeiculosData.Repository
{
    public class VeiculoRepositorio : IVeiculoRepositorio
    {
        private Contexto _context;
        public VeiculoRepositorio(Contexto context)
        {
            _context = context;
        }
        public IEnumerable<Veiculo> ListarTodosOsVeiculos()
        {
            return _context.Veiculos.ToList();
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

            if (anoFabricacao != 0)
                query = query.Where(v => v.AnoFabricacao == anoFabricacao);

            if (anoModelo != 0)
                query = query.Where(v => v.AnoModelo == anoModelo);

            return query.ToList();
        }
    }
}
