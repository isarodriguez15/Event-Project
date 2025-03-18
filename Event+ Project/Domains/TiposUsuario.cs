using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event__Project.Domains
{
    [Table("TiposUsuario")]
    public class TiposUsuario
    {
        [Key]

        public Guid TipoUsuarioID { get; set; }
        //get -> acessar
        //set -> atribuir

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O Título do tipo usúario é obrigatório! ")]
        public string? TituloTipoUsuario { get; set; }
    }
}