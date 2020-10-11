using System.Collections.Generic;

namespace BilgeAdam.Api.Client.Dtos
{
    internal class PokemonListResponse
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<PokemonResponseBasicInfo> Results { get; set; }
    }
}
