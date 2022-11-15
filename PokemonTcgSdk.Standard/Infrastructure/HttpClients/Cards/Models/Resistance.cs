using System.Text.Json.Serialization;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards.Models;

public class Resistance
{
    [JsonPropertyName("type")] public string Type { get; set; }

    [JsonPropertyName("value")] public string Value { get; set; }
}