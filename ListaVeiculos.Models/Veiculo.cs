using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Veiculo
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }

    [Required]
    [Column("Placa")]
    public string Placa { get; set; }

    [Required]
    [Column("Chassi")]
    public string Chassi { get; set; }

    [Required]
    [Column("Marca")]
    public string Marca { get; set; }

    [Required]
    [Column("Modelo")]
    public string Modelo { get; set; }

    [Required]
    [Column("AnoFabricacao")]
    public int AnoFabricacao { get; set; }

    [Required]
    [Column("AnoModelo")]
    public int AnoModelo { get; set; }

    [Required]
    [Column("ValorTabelaFipe")]
    public decimal ValorTabelaFipe { get; set; }

    [Required]
    [Column("ValorVenda")]
    public decimal ValorVenda { get; set; }

    [Column("Observacoes")]
    public string Observacoes { get; set; }

    [Column("DataCadastro")]
    public DateTime DataCadastro { get; set; }
}
