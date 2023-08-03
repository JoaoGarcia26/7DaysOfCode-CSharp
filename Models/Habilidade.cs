using System.Text.Json.Serialization;

namespace _7DaysOfCode_C_.Models;

public class Habilidade
{
    public Habilidade() 
    {
        Nome = null;
    }
    [JsonPropertyName("name")]
    public string? Nome { get; set; }
}