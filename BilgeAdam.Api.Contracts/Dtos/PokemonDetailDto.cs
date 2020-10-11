using System.Collections.Generic;

namespace BilgeAdam.Api.Contracts.Dtos
{
    public class PokemonDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<string> Types { get; set; }
    }
}
