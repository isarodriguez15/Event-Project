using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event__Project.Domains
{
    [Table("PresencaEventos")]
    public class PresencaEventos
    {
        [Key]
        public Guid IdPresencaEvento { get; set; }

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = " Situacao obrigatório!")]
        public bool Situacao { get; set; }

        [Required(ErrorMessage = " Usuário obrigatório!")]
        public Guid IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuarios? Usuarios { get; set; }

        [Required(ErrorMessage = " Evento obrigatório!")]
        public Guid IdEvento { get; set; }
        [ForeignKey("IdEvento")]
        public Evento? Evento { get; set; }
    }
}
