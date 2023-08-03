using _7DaysOfCode_C_.Models;
using _7DaysOfCode_C_.View;

namespace _7DaysOfCode_C_.Controller;

internal class TamagotchiLoginController
{
    private TamagotchiView tamagotchiView;
    public Usuario usuario { get; set;}
    public TamagotchiLoginController()
    {
        tamagotchiView = new TamagotchiView();
        usuario = new Usuario();
    }
    public string Login()
    {
        tamagotchiView.MenuLogin();
        usuario.Nome = Console.ReadLine();
        return usuario.Nome;
    }
}
