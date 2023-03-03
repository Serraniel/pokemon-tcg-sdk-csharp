using System.Collections.Generic;
using System.Text.Json.Serialization;
using PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards.Models;
using PokemonTcgSdk.Standard.Infrastructure.HttpClients.CommonModels;

namespace PokemonTcgSdk.Standard.Infrastructure.HttpClients.Cards;

public class PokemonCard : ApiResource
{
    internal new static string ApiEndpoint { get; } = "cards?q=supertype:pokemon";

    [JsonPropertyName("id")] public override string Id { get; set; }

    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("supertype")] public string Supertype { get; set; }

    [JsonPropertyName("subtypes")] public List<string> Subtypes { get; set; }

    [JsonPropertyName("level")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Level { get; set; }

    [JsonPropertyName("hp")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public int Hp { get; set; }

    [JsonPropertyName("types")] public List<string> Types { get; set; }

    [JsonPropertyName("evolvesFrom")] public string EvolvesFrom { get; set; }

    [JsonPropertyName("ancientTrait")] public AncientTrait AncientTrait { get; set; }

    [JsonPropertyName("abilities")] public List<Ability> Abilities { get; set; }

    [JsonPropertyName("attacks")] public List<Attack> Attacks { get; set; }

    [JsonPropertyName("weaknesses")] public List<Resistance> Weaknesses { get; set; }

    [JsonPropertyName("resistances")] public List<Resistance> Resistances { get; set; }

    [JsonPropertyName("retreatCost")] public List<string> RetreatCost { get; set; }

    [JsonPropertyName("convertedRetreatCost")]
    public int ConvertedRetreatCost { get; set; }

    [JsonPropertyName("set")] public Set.Set Set { get; set; }

    [JsonPropertyName("number")] public string Number { get; set; }

    [JsonPropertyName("artist")] public string Artist { get; set; }

    [JsonPropertyName("rarity")] public string Rarity { get; set; }

    [JsonPropertyName("nationalPokedexNumbers")]
    public List<int> NationalPokedexNumbers { get; set; }

    [JsonPropertyName("legalities")] public Legalities Legalities { get; set; }

    [JsonPropertyName("images")] public CardImage Images { get; set; }

    [JsonPropertyName("tcgplayer")] public TcgPlayer Tcgplayer { get; set; }

    [JsonPropertyName("cardmarket")] public CardMarket Cardmarket { get; set; }

    [JsonPropertyName("evolvesTo")] public List<string> EvolvesTo { get; set; }

    [JsonPropertyName("flavorText")] public string FlavorText { get; set; }

    [JsonPropertyName("rules")] public List<string> Rules { get; set; }

    [JsonPropertyName("regulationMark")] public string RegulationMark { get; set; }
}