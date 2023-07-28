using System.Text.Json.Serialization;

namespace _7DaysOfCode_C_.Models;

internal class Mascote
{
    [JsonPropertyName("name")]
    public string? Nome { get; set; }
    [JsonPropertyName("height")]
    public int? Altura { get; set; }
    [JsonPropertyName("weight")]
    public int? Peso { get;set;}
    [JsonPropertyName("abilities")]
    public List<Habilidades>? Habilidades { get; set; }

    public void ExibirDetalhes()
    {
        List<string> list = new();
        foreach (var item in Habilidades!)
        {
            list.Add(item.Habilidade.Nome);
        }
        Console.WriteLine($"Nome Pokemon: {Nome.ToUpper()} \nAltura: {Altura} \nPeso: {Peso} \nHabilidades: " +
            $"{string.Join(", ", list).ToUpper()} ");
    }
}
