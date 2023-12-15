using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class RegistroLogin
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [Column("codigo")]
    public string Codigo { get; set; }

    [Required]
    [Column("user")]
    public string User { get; set; }

    [Required]
    [Column("token")]
    public string Token { get; set; }
}
