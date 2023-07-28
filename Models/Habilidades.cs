using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _7DaysOfCode_C_.Models;

class Habilidades
{
    [JsonPropertyName("ability")]
    public List<Habilidade> ListaHabilidade { get; set; }

    public void ExibirDetalhes()
    {
        foreach (var item in ListaHabilidade)
        {
            Console.WriteLine(item.Nome);
        }
    }
}
