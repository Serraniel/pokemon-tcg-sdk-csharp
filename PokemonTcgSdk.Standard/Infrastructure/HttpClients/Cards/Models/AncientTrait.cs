using System.Text.Json.Serialization;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards.Models;

public class AncientTrait
{
    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("text")] public string Text { get; set; }
}