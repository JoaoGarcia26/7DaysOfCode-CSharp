namespace _7DaysOfCode_C_.Models;

internal class Usuario
{
    public Usuario()
    {
        Nome = null;
        MascoteAdotado = null;
    }

    public string Nome { get; set; }
    public Mascote MascoteAdotado { get; set; }
}
