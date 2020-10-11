using BilgeAdam.Api.Client.Dtos;
using BilgeAdam.Api.Contracts.Dtos;
using System.Collections.Generic;

namespace BilgeAdam.Api.Client
{
    internal class DataMapper
    {
        public static IEnumerable<PokemonListDto> MapToPokemonList(PokemonListResponse data)
        {
            foreach (var pokemon in data.Results)
            {
                yield return new PokemonListDto
                {
                    Name = pokemon.Name.Substring(0, 1).ToUpper() + pokemon.Name.Substring(1),
                    Id = int.Parse(pokemon.Url.Trim('/').Substring(pokemon.Url.Trim('/').LastIndexOf('/') + 1))
                };
            }
        }

        public static PokemonDetailDto MapToPokemonDetail(PokemonDetailResponse data)
        {
            var types = new List<string>();
            foreach (var type in data.Types)
            {
                types.Add(type.Type.Name);
            }
            return new PokemonDetailDto
            {
                Id = data.Id,
                Height = data.Height,
                Weight = data.Weight,
                Name = data.Name,
                Types = types
            };
        }
    }
}
