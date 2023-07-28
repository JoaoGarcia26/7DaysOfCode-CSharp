using System.Text.Json.Serialization;

namespace _7DaysOfCode_C_.Models;

class Habilidade
{
    [JsonPropertyName("name")]
    public string? Nome { get; set; }
}