using System.Text.Json.Serialization;

namespace _7DaysOfCode_C_.Models;

public class Mascote
{
    public Mascote()
    {
        Nome = null;
        Altura = null;
        Peso = null;
        Habilidades = null;
    }

    public Mascote(Mascote mascote)
    {
        Nome = mascote.Nome;
        Altura= mascote.Altura;
        Peso = mascote.Peso;
        Habilidades = mascote.Habilidades;
    }

    [JsonPropertyName("name")]
    public string? Nome { get; set; }
    [JsonPropertyName("height")]
    public int? Altura { get; set; }
    [JsonPropertyName("weight")]
    public int? Peso { get;set;}
    [JsonPropertyName("abilities")]
    public List<Habilidades>? Habilidades { get; set; }

}
