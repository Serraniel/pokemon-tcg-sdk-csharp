using System;
using System.Text.Json.Serialization;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards.Models;

public class TcgPlayer
{
    [JsonPropertyName("url")] public Uri Url { get; set; }

    [JsonPropertyName("updatedAt")] public string UpdatedAt { get; set; }

    [JsonPropertyName("prices")] public TcgPlayerPrices Prices { get; set; }
}

/// <summary>
///     Price information for a card.
/// </summary>
/// <remarks>All prices are in US Dollars.</remarks>
public class TcgPlayerPrices
{
    [JsonPropertyName("holofoil")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Prices Holofoil { get; set; }

    [JsonPropertyName("reverseHolofoil")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Prices ReverseHolofoil { get; set; }

    [JsonPropertyName("normal")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Prices Normal { get; set; }

    [JsonPropertyName("1stEditionHolofoil")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Prices The1StEditionHolofoil { get; set; }

    [JsonPropertyName("unlimitedHolofoil")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Prices UnlimitedHolofoil { get; set; }

    [JsonPropertyName("1stEdition")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Prices The1StEdition { get; set; }

    [JsonPropertyName("unlimited")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Prices Unlimited { get; set; }
}

public class Prices
{
    [JsonPropertyName("low")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double? Low { get; set; }

    [JsonPropertyName("mid")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double? Mid { get; set; }

    [JsonPropertyName("high")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double? High { get; set; }

    [JsonPropertyName("market")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double? Market { get; set; }

    [JsonPropertyName("directLow")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double? DirectLow { get; set; }
}