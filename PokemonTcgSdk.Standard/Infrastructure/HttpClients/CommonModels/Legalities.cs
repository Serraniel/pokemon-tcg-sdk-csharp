using System.Text.Json.Serialization;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.CommonModels;

public class Legalities
{
    [JsonPropertyName("unlimited")] public string Unlimited { get; set; }

    [JsonPropertyName("standard")] public string Standard { get; set; }

    [JsonPropertyName("expanded")] public string Expanded { get; set; }
}