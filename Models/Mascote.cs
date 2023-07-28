using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _7DaysOfCode_C_.Models;

internal class Mascote
{
    [JsonPropertyName("name")]
    public string Nome {get;set;}
    [JsonPropertyName("height")]
    public int Altura { get; set; }
    [JsonPropertyName("weight")]
    public int Peso { get;set;}
    [JsonPropertyName("abilities")]
    public Habilidades Habilidades { get;set;}

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome Pokemon: {Nome} \nAltura: {Altura} \nPeso: {Peso} \nHabilidades: {Habilidades.ExibirDetalhes} ");
    }
}
