using ListaVeiculos.Business.Dto;

public static class MapperVeiculo
{
    public static VeiculoDto MapearVeiculoParaDto(Veiculo veiculo)
    {
        return new VeiculoDto
        {
            Id = veiculo.Id,
            Placa = veiculo.Placa,
            Chassi = veiculo.Chassi,
            Marca = veiculo.Marca,
            Modelo = veiculo.Modelo,
            AnoFabricacao = veiculo.AnoFabricacao,
            AnoModelo = veiculo.AnoModelo,
            ValorTabelaFipe = veiculo.ValorTabelaFipe,
            ValorVenda = veiculo.ValorVenda,
            Observacoes = veiculo.Observacoes,
            DataCadastro = veiculo.DataCadastro
        };
    }

    public static Veiculo MapearVeiculoParaEntidade(VeiculoDto veiculoDto)
    {
        return new Veiculo
        {
            Id = veiculoDto.Id,
            Placa = veiculoDto.Placa,
            Chassi = veiculoDto.Chassi,
            Marca = veiculoDto.Marca,
            Modelo = veiculoDto.Modelo,
            AnoFabricacao = veiculoDto.AnoFabricacao,
            AnoModelo = veiculoDto.AnoModelo,
            ValorTabelaFipe = veiculoDto.ValorTabelaFipe,
            ValorVenda = veiculoDto.ValorVenda,
            Observacoes = veiculoDto.Observacoes,
            DataCadastro = veiculoDto.DataCadastro
        };
    }
}
