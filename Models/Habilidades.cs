using System.Text.Json.Serialization;

namespace _7DaysOfCode_C_.Models;

public class Habilidades
{
    public Habilidades() 
    {
        Habilidade = new Habilidade();
    }
    [JsonPropertyName("ability")]
    public Habilidade? Habilidade { get; set; }

}