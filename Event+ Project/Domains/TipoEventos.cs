using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Event__Project.Domains
{
    [Table("TipoEventos")]
    public class TipoEventos
    {
            [Key]
            public Guid IdTipoEventos { get; set; }

            [Column(TypeName = "VARCHAR(60)")]
            [Required(ErrorMessage = "O Título tipo evento é obrigatório")]
            public string? TituloEvento { get; set; }

    }
}

