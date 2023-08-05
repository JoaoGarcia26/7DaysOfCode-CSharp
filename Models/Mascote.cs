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
        _alimentacao = 5;
        _humor = 5;
        _sono = 5;
    }

    public Mascote(Mascote mascote)
    {
        Nome = mascote.Nome;
        Altura = mascote.Altura;
        Peso = mascote.Peso;
        Habilidades = mascote.Habilidades;
        _alimentacao = 5;
        _humor = 5;
        _sono = 5;
    }

    [JsonPropertyName("name")]
    public string? Nome { get; set; }
    [JsonPropertyName("height")]
    public int? Altura { get; set; }
    [JsonPropertyName("weight")]
    public int? Peso { get; set; }
    [JsonPropertyName("abilities")]
    public List<Habilidades>? Habilidades { get; set; }

    private int _alimentacao;
    private int _sono;
    private int _humor;
    //0 MUITA FOME
    //10 POUCA FOME
    public int Alimentacao
    {
        get => _alimentacao;
        set { if ((value >= 0) && (value <= 10)) { _alimentacao = value; } }
    }
    //0 SEM SONO
    //10 MUITO SONO
    public int Sono
    {
        get => _sono;
        set { if ((value >= 0) && (value <= 10)) { _sono = value; } }
    }
    //0 TRISTE
    //10 FELIZ
    public int Humor
    {
        get => _humor;
        set { if ((value >= 0) && (value <= 10)) { _humor = value; } }
    }

    public void Brincar()
    {
        Alimentacao--;
        Humor++;
        Sono++;
    }
    public void Alimentar()
    {
        Alimentacao++;
        Sono++;
    }
    public void Dormir()
    {
        Alimentacao--;
        Sono--;
    }

    public string VerificaFome()
    {
        string resultado = null;

        if (_alimentacao >= 0 && _alimentacao < 5 ) { resultado = "Está com fome :("; }
        else if(_alimentacao >= 5 && _alimentacao <= 10) { resultado = "Está sem fome :)"; }

        return resultado;
    }
    public string VerificaHumor()
    {
        string resultado = null;

        if (_humor >= 0 && _humor < 5) { resultado = "Está triste :("; }
        else if (_humor >= 5 && _humor <= 10) { resultado = "Está feliz :)"; }

        return resultado;
    }
    public string VerificaSono()
    {
        string resultado = null;

        if (_sono >= 0 && _sono < 5) { resultado = "Está sem sono :)"; }
        else if (_sono >= 5 && _sono <= 10) { resultado = "Está com sono :("; }

        return resultado;
    }

}
