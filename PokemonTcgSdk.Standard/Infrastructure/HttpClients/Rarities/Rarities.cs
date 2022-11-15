using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.Rarities;

public class Rarities : ResourceBase
{
    [JsonPropertyName("data")] public List<string> Rarity { get; set; }

    internal new static string ApiEndpoint { get; } = "rarities";

    public override string Id { get; set; }
}