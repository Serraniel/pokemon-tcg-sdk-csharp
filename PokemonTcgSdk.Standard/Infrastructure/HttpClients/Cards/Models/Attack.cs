using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards.Models;

public class Attack
{
    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("cost")] public List<string> Cost { get; set; }

    [JsonPropertyName("convertedEnergyCost")]
    public long ConvertedEnergyCost { get; set; }

    [JsonPropertyName("damage")] public string Damage { get; set; }

    [JsonPropertyName("text")] public string Text { get; set; }
}