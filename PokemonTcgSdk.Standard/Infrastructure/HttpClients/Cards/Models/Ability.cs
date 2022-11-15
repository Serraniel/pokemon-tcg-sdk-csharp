using System.Text.Json.Serialization;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards.Models;

public class Ability
{
    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("text")] public string Text { get; set; }

    [JsonPropertyName("type")] public string Type { get; set; }
}