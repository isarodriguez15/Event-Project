using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Event__Project.Domains
{
    [Table("Evento")]
    public class Evento
    {
        [Key]
        public Guid IdEvento { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A data do evento é obrigatória!")]
        public DateTime DataEvento { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "A data é obrigatório no convite do evento")]
        public string? NomeEvento { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descrição do evento obrigatório")]
        public string? Descricao { get; set; }

        public Guid IdTipoEvento { get; set; }
        [ForeignKey("IdTipoEvento")]
        public TipoEventos? TiposEvento { get; set; }

        public Guid IdInstituicao { get; set; }
        [ForeignKey("IdInstituicao")]
        public Institucoes? Instituicao { get; set; }

        public PresencaEventos? PresencaEventos { get; set; }
    }
}

