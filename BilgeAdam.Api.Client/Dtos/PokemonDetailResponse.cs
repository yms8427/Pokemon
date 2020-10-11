using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Api.Client.Dtos
{
    class PokemonDetailResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<PokemonType> Types { get; set; }
    }

    class PokemonType
    {
        public SpecialType Type { get; set; }
    }

    class SpecialType
    {
        public string Name { get; set; }
    }
}
