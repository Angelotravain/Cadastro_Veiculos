namespace ListaVeiculos.Business.Dto
{
    public class VeiculoDto
    {
        public int Id { get; set; }
        public string? Placa { get; set; }
        public string? Chassi { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public decimal ValorTabelaFipe { get; set; }
        public decimal ValorVenda { get; set; }
        public string? Observacoes { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
