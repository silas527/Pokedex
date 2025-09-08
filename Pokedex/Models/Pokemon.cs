using System.ComponenteModel.DataAnnotation.Schema;
using System.ComponenteModel.DataAnnotation;

namespace Pokedex.Models
{   [Table("Pokemon")]

    public class Pokemon
    {
        [Key]
        [DatabaseGenerated(DatabaseGenerated.None)]

        public uint Numero {get; set; }

        [Required(ErrorMessage = 'Por favor, informe a região')]

        public uint RegiaoId { get; set; }
        [ForeignKey("RegiaoId")]

        public Regiao Regiao { get; set; }

        [Required(ErrorMessage = "Por favor, informe o gênero")]

        public uint GeneroId { get; set; }
        [ForegnKey("GeneroId")]
        public Genero Genero { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Por favor, informe o nome")]

        public string Nome { get; set; }

        p[StringLength(1000)]

        public string Descricao { get; set; }

        [Column(TypeName = "double(5, 2)")]
        [Required(ErrorMessage = "Por favor, informe a altura")]
        public double Peso { get; set; }

         [Column(TypeName = "double(7, 3)")]
        [Required(ErrorMessage = "Por favor, informe a peso")]
        public double Peso { get; set; }
        
        [StringLength(200)]
        public string Imagem {get; set;}

        [StringLength(400)]
        public string Animacao {get; set;}

        public List <PokemonTipo> Tipos {get; set;}
    }
}