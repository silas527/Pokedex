using System.ComponenteModel.DataAnnotation.Schema;
using System.ComponenteModel.DataAnnotation;

namespace Pokedex.Models
{
    public class Genero
    {
         [Key]

        public unit Id { get; set; }

        [StringLength (25)]
        [Required(ErrorMessage = "Por favor, informe o nome")]

        public string Nome { get; set;}
    }
}