using _7DaysOfCode_C_.Models;
using _7DaysOfCode_C_.View;

namespace _7DaysOfCode_C_.Controller;

internal class TamagotchiInteractionController
{
    private TamagotchiView tamagotchiView;
    public TamagotchiInteractionController()
    {
        tamagotchiView = new TamagotchiView();
    }
    public void MenuInteracao(string userName, Mascote mascote)
    {
        bool jogar = true;
        int opcao;
        while(jogar == true)
        {
            tamagotchiView.MenuSeuMascote(userName, mascote);
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    tamagotchiView.MenuAlimentar(mascote);
                    break;
                case 2:
                    tamagotchiView.MenuBrincar(mascote);
                    break;
                case 3:
                    tamagotchiView.MenuDormir(mascote);
                    break;
                case 4:
                    tamagotchiView.DashboardCompletoInteracao(mascote);
                    break;
                case 5:
                    jogar = false;
                    break;
                default: throw new NotImplementedException("Opção Invalida!");
            }
        }
    }
}
