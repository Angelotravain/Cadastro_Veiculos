namespace ListaVeiculosData.Repository.Interface
{
    public interface IVeiculoRepositorio
    {
        IEnumerable<Veiculo> FiltrarVeiculoPorParametros(string placa = "", string chassi = "", string marca = "", string modelo = "", int anoFabricacao = 0, int anoModelo = 0);
         IEnumerable<Veiculo> ListarTodosOsVeiculos();
    }
}
