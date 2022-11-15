using System;
using System.Text.Json.Serialization;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards.Models;

public class CardImage
{
    [JsonPropertyName("small")] public Uri Small { get; set; }

    [JsonPropertyName("large")] public Uri Large { get; set; }
}