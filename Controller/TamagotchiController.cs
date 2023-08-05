using _7DaysOfCode_C_.View;

namespace _7DaysOfCode_C_.Controller;

public class TamagotchiController
{
    private TamagotchiLoginController tamagotchiLoginController;
    private TamagotchiAdoptController tamagotchiAdoptController;
    private TamagotchiInteractionController tamagotchiInteractionController;
    private TamagotchiView tamagotchiView;

    public TamagotchiController()
    {
        tamagotchiLoginController = new TamagotchiLoginController();
        tamagotchiAdoptController = new TamagotchiAdoptController();
        tamagotchiInteractionController = new TamagotchiInteractionController();
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
                            
                            if (tamagotchiLoginController.Usuario.MascoteAdotado == null)
                            {
                                tamagotchiLoginController.Usuario.MascoteAdotado = tamagotchiAdoptController.AdotarMascote(opcaoMascote);
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
                    if (tamagotchiLoginController.Usuario.MascoteAdotado != null)
                    {
                        tamagotchiInteractionController.MenuInteracao(userName, tamagotchiLoginController.Usuario.MascoteAdotado);
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

    
}