using _7DaysOfCode_C_.Models;
using _7DaysOfCode_C_.View;

namespace _7DaysOfCode_C_.Controller;

internal class TamagotchiLoginController
{
    private TamagotchiView tamagotchiView;
    public Usuario Usuario { get; set;}
    public TamagotchiLoginController()
    {
        tamagotchiView = new TamagotchiView();
        Usuario = new Usuario();
    }
    public string Login()
    {
        tamagotchiView.MenuLogin();
        Usuario.Nome = Console.ReadLine();
        return Usuario.Nome;
    }
}
