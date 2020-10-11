using BilgeAdam.Api.Client.Dtos;
using BilgeAdam.Api.Contracts.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace BilgeAdam.Api.Client
{
    public class ApiManager
    {
        private readonly string baseUrl = "https://pokeapi.co";
        public List<PokemonListDto> GetAll()
        {
            var client = new HttpClient() { BaseAddress = new Uri(baseUrl) };
            var response = client.GetAsync("/api/v2/pokemon/?offset=0&limit=151").Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<PokemonListResponse>(json);
            return DataMapper.MapToPokemonList(result).ToList();
        }

        public PokemonDetailDto GetDetail(int id)
        {
            var client = new HttpClient() { BaseAddress = new Uri(baseUrl) };
            var response = client.GetAsync($"/api/v2/pokemon/{id}").Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<PokemonDetailResponse>(json);
            return DataMapper.MapToPokemonDetail(result);
        }
    }
}
