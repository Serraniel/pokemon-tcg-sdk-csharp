using System.Text.Json.Serialization;
using PokemonTcgSdk.Standard.Infrastructure.HttpClients.CommonModels;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.Set;

public class Set : ApiResource
{
    public override string Id { get; set; }

    internal new static string ApiEndpoint { get; } = "sets";

    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("series")] public string Series { get; set; }

    [JsonPropertyName("printedTotal")] public long PrintedTotal { get; set; }

    [JsonPropertyName("total")] public long Total { get; set; }

    [JsonPropertyName("legalities")] public Legalities Legalities { get; set; }

    [JsonPropertyName("ptcgoCode")] public string PtcgoCode { get; set; }

    [JsonPropertyName("releaseDate")] public string ReleaseDate { get; set; }

    [JsonPropertyName("updatedAt")] public string UpdatedAt { get; set; }

    [JsonPropertyName("images")] public Images Images { get; set; }
}