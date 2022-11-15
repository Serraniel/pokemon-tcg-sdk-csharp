using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.SubTypes;

public class SubTypes : ResourceBase
{
    public override string Id { get; set; }

    internal new static string ApiEndpoint { get; } = "subtypes";

    [JsonPropertyName("data")] public List<string> SubType { get; set; }
}