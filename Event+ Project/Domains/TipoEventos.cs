using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Event__Project.Domains
{
    [Table("TipoEvento")]
    public class TipoEventos
    {
            [Key]
            public Guid IdTipoEvento { get; set; }

            [Column(TypeName = "VARCHAR(60)")]
            [Required(ErrorMessage = "O Título tipo evento é obrigatório")]
            public string? TituloEvento { get; set; }
        }
    }

