using System;
using System.Text.Json.Serialization;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.CommonModels;

public class Images
{
    [JsonPropertyName("symbol")] public Uri Symbol { get; set; }

    [JsonPropertyName("logo")] public Uri Logo { get; set; }
}