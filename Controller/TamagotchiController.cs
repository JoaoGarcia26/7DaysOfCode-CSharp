using _7DaysOfCode_C_.Models;
using _7DaysOfCode_C_.Service;
using _7DaysOfCode_C_.View;

namespace _7DaysOfCode_C_.Controller;

public class TamagotchiController
{
    private TamagotchiLoginController tamagotchiLoginController;
    private TamagotchiService tamagotchiService;
    private TamagotchiView tamagotchiView;
    public TamagotchiController()
    {
        tamagotchiLoginController = new TamagotchiLoginController();
        tamagotchiService = new TamagotchiService();
        tamagotchiView = new TamagotchiView();
    }
    public void Jogar()
    {
        int opcao;
        int opcaoMascote;
        string userName = tamagotchiLoginController.Login();
        bool jogar = true;

        while (jogar == true) {
            tamagotchiView.MenuPrimario(userName);
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                //MENU DE MASCOTES
                case 1:
                    tamagotchiView.MenuDeMascotes(userName);
                    opcao = int.Parse(Console.ReadLine());
                    opcaoMascote = opcao;
                    tamagotchiView.MenuMascoteSelecionado(userName, opcao);
                    opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        //VER DETALHES
                        case 1:
                            
                            tamagotchiView.SaberMaisSobreMascote(opcaoMascote);
                            break;
                        //ADOTAR
                        case 2:
                            
                            if (tamagotchiLoginController.usuario.MascoteAdotado == null)
                            {
                                tamagotchiLoginController.usuario.MascoteAdotado = AdotarMascote(opcaoMascote);
                            }
                        break;
                        //VOLTAR
                        case 3:
                            
                            tamagotchiView.Sair(userName);
                            break;
                        default:
                            throw new NotImplementedException("Opção Invalida!");
                    }
                break;
                //ADOTAR
                case 2:
                    if (tamagotchiLoginController.usuario.MascoteAdotado != null)
                    {
                        tamagotchiView.ExibirDescricaoCompletaMascote(tamagotchiLoginController.usuario.MascoteAdotado);
                    }
                    else
                    {
                        Console.WriteLine("Voce não tem um mascote! :(");
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    break;
                //SAIR
                case 3:
                    //SAIR
                    tamagotchiView.Sair(userName);
                    jogar = false;
                    break;
                default:
                    throw new NotImplementedException("Opção Invalida!");
            }
        }
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