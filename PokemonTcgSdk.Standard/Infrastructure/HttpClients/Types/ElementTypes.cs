using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.Types;

public class ElementTypes : ResourceBase
{
    [JsonPropertyName("data")] public List<string> ElementType { get; set; }

    internal new static string ApiEndpoint { get; } = "types";

    public override string Id { get; set; }
}