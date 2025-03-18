using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Event__Project.Domains
{
        
   [Table("Usuarios")]
   [Index(nameof(Email), IsUnique = true)]
      
    public class Usuarios
    {
            [Key]
            public Guid IdUsuario { get; set; }

            [Column(TypeName = "VARCHAR(50)")]
            [Required(ErrorMessage = "O nome é obrigatório!")]
            public string? Nome { get; set; }

            [Column(TypeName = "VARCHAR(50)")]
            [Required(ErrorMessage = "O email é obrigatório!")]
            public string? Email { get; set; }

            [Column(TypeName = "VARCHAR(60)")]
            [Required(ErrorMessage = "A senha é obrigatória!")]
            [StringLength(60, MinimumLength = 6, ErrorMessage = "A senha deve ter no mínimo 6 caracteres e no máximo 60")]
            public string? Senha { get; set; }

            [Required(ErrorMessage = "O tipo do usúario é obrigatório")]
            public  Guid IdTipoUsuario { get; set; }
            [ForeignKey("IdTipoUsuario")]
            public TiposUsuario? TipoUsuario { get; set; }
        }
    }



