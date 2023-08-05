using _7DaysOfCode_C_.Models;
using _7DaysOfCode_C_.Service;
using _7DaysOfCode_C_.View;

namespace _7DaysOfCode_C_.Controller;

internal class TamagotchiAdoptController
{
    private readonly TamagotchiService tamagotchiService;
    private readonly TamagotchiView tamagotchiView;

    public TamagotchiAdoptController()
    {
        tamagotchiService = new TamagotchiService();
        tamagotchiView = new TamagotchiView();
    }

    public Mascote AdotarMascote(int opcaoMascote)
    {
        Mascote mascote;
        switch (opcaoMascote)
        {
            case 1:
                mascote = new Mascote(tamagotchiService.InvocarGet("bulbasaur"));
                tamagotchiView.MenuAdotarMascoteSucesso();
                break;
            case 2:
                mascote = new Mascote(tamagotchiService.InvocarGet("charmander"));
                tamagotchiView.MenuAdotarMascoteSucesso();
                break;
            case 3:
                mascote = new Mascote(tamagotchiService.InvocarGet("squirtle"));
                tamagotchiView.MenuAdotarMascoteSucesso();
                break;
            case 4:
                mascote = new Mascote(tamagotchiService.InvocarGet("pikachu"));
                tamagotchiView.MenuAdotarMascoteSucesso();
                break;
            default:
                throw new NotImplementedException("Opção Invalida!");
        }
        return mascote;
    }
}
