using System.Collections.Generic;
using System.Text.Json.Serialization;
using PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards.Models;
using PokemonTcgSdk.Standard.Infrastructure.HttpClients.CommonModels;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards;

public class TrainerCard : ApiResource
{
    internal new static string ApiEndpoint { get; } = "cards?q=supertype:trainer";

    public override string Id { get; set; }

    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("supertype")] public string Supertype { get; set; }

    [JsonPropertyName("rules")] public List<string> Rules { get; set; }

    [JsonPropertyName("set")] public Set.Set Set { get; set; }

    [JsonPropertyName("number")] public string Number { get; set; }

    [JsonPropertyName("artist")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Artist { get; set; }

    [JsonPropertyName("rarity")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Rarity { get; set; }

    [JsonPropertyName("legalities")] public Legalities Legalities { get; set; }

    [JsonPropertyName("images")] public CardImage Images { get; set; }

    [JsonPropertyName("tcgplayer")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public TcgPlayer Tcgplayer { get; set; }

    [JsonPropertyName("cardmarket")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public CardMarket Cardmarket { get; set; }

    [JsonPropertyName("subtypes")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<string> Subtypes { get; set; }

    [JsonPropertyName("attacks")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<Attack> Attacks { get; set; }

    [JsonPropertyName("regulationMark")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string RegulationMark { get; set; }

    [JsonPropertyName("hp")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int Hp { get; set; }

    [JsonPropertyName("abilities")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<Ability> Abilities { get; set; }
}