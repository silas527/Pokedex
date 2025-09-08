using System.ComponenteModel.DataAnnotation.Schema;
using System.ComponenteModel.DataAnnotation;

namespace Pokedex.Models
{
    public class PokemonTipo
    {
        [Table("PokemonTipo")]

        public uint PokemonNumero {get; set;}

        [ForegnKey("PokemonNumero")]

        public Pokemon Pokemon { get; set; }
    }
}