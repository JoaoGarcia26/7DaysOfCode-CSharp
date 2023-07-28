using System.Text.Json.Serialization;

namespace _7DaysOfCode_C_.Models;

class Habilidades
{
    [JsonPropertyName("ability")]
    public Habilidade? Habilidade { get; set; }

}