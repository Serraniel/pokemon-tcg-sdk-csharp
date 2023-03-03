using System;
using System.Text.Json.Serialization;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards.Models;

public class CardMarket
{
    [JsonPropertyName("url")] public Uri Url { get; set; }

    [JsonPropertyName("updatedAt")] public string UpdatedAt { get; set; }

    [JsonPropertyName("prices")] public CardMarketPrices Prices { get; set; }
}

/// <summary>
///     Price information for a card.
/// </summary>
/// <remarks>All prices are in Euros.</remarks>
public class CardMarketPrices
{
    /// <summary>
    ///     The average sell price as shown in the chart at the website for non-foils.
    /// </summary>
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? AverageSellPrice { get; set; }

    /// <summary>
    ///     The lowest price at the market for non-foils.
    /// </summary>
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? LowPrice { get; set; }

    /// <summary>
    ///     The trend price as shown at the website (and in the chart) for non-foils.
    /// </summary>
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? TrendPrice { get; set; }

    /// <summary>
    ///     The average sell price as shown in the chart at the website for reverse holos.
    /// </summary>
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? ReverseHoloSell { get; set; }

    /// <summary>
    ///     The lowest price at the market as shown at the website (for condition EX+) for reverse holos.
    /// </summary>
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? ReverseHoloLow { get; set; }

    /// <summary>
    ///     The trend price as shown at the website (and in the chart) for reverse holos.
    /// </summary>
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? ReverseHoloTrend { get; set; }

    /// <summary>
    ///     The lowest price at the market for non-foils with condition EX or better.
    /// </summary>
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? LowPriceExPlus { get; set; }

    /// <summary>
    ///     The average sale price over the last day.
    /// </summary>
    [JsonPropertyName("avg1")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? AverageDay { get; set; }

    /// <summary>
    ///     The average sale price over the last 7 days.
    /// </summary>
    [JsonPropertyName("avg7")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? AverageWeek { get; set; }

    /// <summary>
    ///     The average sale price over the last 30 days.
    /// </summary>
    [JsonPropertyName("avg30")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? AverageMonth { get; set; }

    /// <summary>
    ///     The average sale price over the last day for reverse holos.
    /// </summary>
    [JsonPropertyName("reverseHoloAvg1")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? AverageDayReverseHolo { get; set; }

    /// <summary>
    ///     The average sale price over the last 7 days for reverse holos.
    /// </summary>
    [JsonPropertyName("reverseHoloAvg7")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? AverageWeekReverseHolo { get; set; }

    /// <summary>
    ///     The average sale price over the last 30 days for reverse holos.
    /// </summary>
    [JsonPropertyName("reverseHoloAvg30")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? AverageMonthReverseHolo { get; set; }
}