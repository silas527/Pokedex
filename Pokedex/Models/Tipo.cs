using System.ComponenteModel.DataAnnotation.Schema;
using System.ComponenteModel.DataAnnotation;
namespace Pokedex.Models
{
    [Table("Tipo")]

    public class Tipo
    {
        [Key]

        public unit Id { get; set; }

        [StringLength (25)]

        public string Cor { get; set;}
    }
}