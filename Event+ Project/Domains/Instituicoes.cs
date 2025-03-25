using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Event__Project.Interfaces;

namespace Event__Project.Domains
{

        [Table("Instituicoes")]
        [Index(nameof(CNPJ), IsUnique = true)]
    public class Institucoes
        {
            [Key]
            public Guid IdInstituicao { get; set; }

            [Column(TypeName = "VARCHAR(30)")]
            [Required(ErrorMessage = "O CNPJ é obrigatório")]
            [StringLength(14)]
            public string? CNPJ  { get; set; }

            [Column(TypeName = "VARCHAR(60)")]
            [Required(ErrorMessage = "O endereco é obrigatório no convite do evento")]
            public string? Endereco { get; set; }

            [Column(TypeName = "VARCHAR(30)")]
            [Required(ErrorMessage = "O nomefantasia é obrigatório")]

            public string? NomeFantasia { get; set; }

         
    }
    }

