using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event__Project.Domains
{
    [Table("ComentarioEvento")]
    public class ComentarioEvento
    {
        [Key]
        public Guid IdComentarioEvento { get; set; }


        [Column(TypeName = "VARCHAR(200)")]
        [Required(ErrorMessage = " Descrição do comentário obrigatório")]
        public string? Descricao { get; set; }


        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = " Exibição do comentário obrigatório")]
        public bool? Exibe { get; set; }

        [Required(ErrorMessage = "Usuário obrigatório")]
        public Guid IdEvento { get; set; }

        [ForeignKey("IdEvento")]
        public Evento? Evento { get; set; }

        //ref.tabela Usuario
        [Required(ErrorMessage = "Usuário obrigatório!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuarios? Usuario { get; set; }

        
    }
}
