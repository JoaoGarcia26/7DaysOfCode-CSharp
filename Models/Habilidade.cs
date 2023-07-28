using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _7DaysOfCode_C_.Models;

class Habilidade
{
    [JsonPropertyName("name")]
    public string Nome { get; set; }
}