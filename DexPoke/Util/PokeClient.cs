using DexPoke.Models;
using System.Text.Json;

namespace DexPoke.Util
{
    public class PokeClient
    {
        public HttpClient client { get; set; }
        public PokeClient(HttpClient client)
        {
                this.client = client;
        }

        public async Task<Pokemon> GetPokemon(string id)
        {
            var response = await this.client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
            var content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Pokemon>(content);
        }
    }
}
