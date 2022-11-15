using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.SuperTypes;

public class SuperTypes : ResourceBase
{
    [JsonPropertyName("data")] public List<string> SuperType { get; set; }

    internal new static string ApiEndpoint { get; } = "supertypes";

    public override string Id { get; set; }
}