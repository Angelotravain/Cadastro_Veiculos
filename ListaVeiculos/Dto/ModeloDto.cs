public class ModeloDto
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
}

public class AnoDto
{
    public string Codigo { get; set; }
    public string Nome { get; set; }
}

public class DadosDto
{
    public List<ModeloDto> Modelos { get; set; }
    public List<AnoDto> Anos { get; set; }
}
