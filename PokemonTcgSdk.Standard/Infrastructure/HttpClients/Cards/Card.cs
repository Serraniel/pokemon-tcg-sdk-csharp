using System.Collections.Generic;
using System.Text.Json.Serialization;
using PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards.Models;
using PokemonTcgSdk.Standard.Infrastructure.HttpClients.CommonModels;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards;

public class Card : ApiResource
{
    public override string Id { get; set; }

    internal new static string ApiEndpoint { get; } = "cards";

    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("supertype")] public string Supertype { get; set; }

    [JsonPropertyName("subtypes")] public List<string> Subtypes { get; set; }

    [JsonPropertyName("level")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Level { get; set; }

    [JsonPropertyName("hp")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int Hp { get; set; }

    [JsonPropertyName("types")] public List<string> Types { get; set; }

    [JsonPropertyName("evolvesFrom")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string EvolvesFrom { get; set; }

    [JsonPropertyName("abilities")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<Ability> Abilities { get; set; }

    [JsonPropertyName("attacks")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<Attack> Attacks { get; set; }

    [JsonPropertyName("weaknesses")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<Resistance> Weaknesses { get; set; }

    [JsonPropertyName("resistances")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<Resistance> Resistances { get; set; }

    [JsonPropertyName("retreatCost")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<string> RetreatCost { get; set; }

    [JsonPropertyName("convertedRetreatCost")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int ConvertedRetreatCost { get; set; }

    [JsonPropertyName("set")] public Set.Set Set { get; set; }

    [JsonPropertyName("number")] public string Number { get; set; }

    [JsonPropertyName("artist")] public string Artist { get; set; }

    [JsonPropertyName("rarity")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Rarity { get; set; }

    [JsonPropertyName("nationalPokedexNumbers")]
    public List<int> NationalPokedexNumbers { get; set; }

    [JsonPropertyName("legalities")] public Legalities Legalities { get; set; }

    [JsonPropertyName("images")] public CardImage Images { get; set; }

    [JsonPropertyName("tcgplayer")] public TcgPlayer Tcgplayer { get; set; }

    [JsonPropertyName("cardmarket")] public CardMarket Cardmarket { get; set; }

    [JsonPropertyName("evolvesTo")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<string> EvolvesTo { get; set; }

    [JsonPropertyName("flavorText")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string FlavorText { get; set; }

    [JsonPropertyName("rules")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<string> Rules { get; set; }

    [JsonPropertyName("regulationMark")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string RegulationMark { get; set; }
}