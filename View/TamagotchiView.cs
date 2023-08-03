using _7DaysOfCode_C_.Models;
using _7DaysOfCode_C_.Service;

namespace _7DaysOfCode_C_.View;

internal class TamagotchiView
{
    private TamagotchiService tamagotchiService;
    public TamagotchiView()
    {
        tamagotchiService = new TamagotchiService();
    }
    public void ExibeLogo()
    {
        Console.Clear();
        Console.WriteLine(@"
                ████████╗░█████╗░███╗░░░███╗░█████╗░░██████╗░░█████╗░████████╗░█████╗░██╗░░██╗██╗
                ╚══██╔══╝██╔══██╗████╗░████║██╔══██╗██╔════╝░██╔══██╗╚══██╔══╝██╔══██╗██║░░██║██║
                ░░░██║░░░███████║██╔████╔██║███████║██║░░██╗░██║░░██║░░░██║░░░██║░░╚═╝███████║██║
                ░░░██║░░░██╔══██║██║╚██╔╝██║██╔══██║██║░░╚██╗██║░░██║░░░██║░░░██║░░██╗██╔══██║██║
                ░░░██║░░░██║░░██║██║░╚═╝░██║██║░░██║╚██████╔╝╚█████╔╝░░░██║░░░╚█████╔╝██║░░██║██║
                ░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░╚═╝░╚═════╝░░╚════╝░░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚═╝" + "\n");
    }
    public void MenuLogin()
    {
        ExibeLogo();
        Console.WriteLine("Insira seu nome: ");
    }
    public void MenuPrimario(string username)
    {
        ExibeLogo();
        Console.WriteLine("---------------- MENU ----------------");
        Console.WriteLine($"{username.ToUpper()}, escolha uma opção: ");
        Console.WriteLine("1 - Menu de mascotes");
        Console.WriteLine("2 - Ver seus mascotes");
        Console.WriteLine("3 - Sair\n");
        Console.Write("Digite a opção desejada: ");
    }
    public void MenuDeMascotes(string username)
    {
        ExibeLogo();
        string listaMascotes = "1 - Bulbasaur\r\n2 - Charmander\r\n3 - Squirtle\r\n4 - Pikachu\n";
        Console.WriteLine("---------------- INFORMAÇÃO SOBRE OS MASCOTES ----------------");
        Console.WriteLine($"{username.ToUpper()}, escolha uma espécie:");
        Console.WriteLine($"{listaMascotes}");
        Console.Write("Digite a opção desejada: ");
    }
    public void MenuMascoteSelecionado(string username, int opcao)
    {
        string nomeMascote = "";
        switch (opcao)
        {
            case 1: nomeMascote = "BULBASAUR"; break;
            case 2: nomeMascote = "CHARMANDER"; break;
            case 3: nomeMascote = "SQUIRTLE"; break;
            case 4: nomeMascote = "PIKACHU"; break;
        }
        
        Console.WriteLine($"---------------- {nomeMascote} ----------------");
        Console.WriteLine($"{username.ToUpper()}, voce deseja: \n");
        Console.WriteLine($"1 - Saber mais sobre {nomeMascote}");
        Console.WriteLine($"2 - Adotar {nomeMascote}");
        Console.WriteLine("3 - Voltar\n");
        Console.Write("Digite a opção desejada: ");
    }
    public void ExibirDescricaoCompletaMascote(Mascote mascote)
    {
        List<string> list = new();
        foreach (var item in mascote.Habilidades!)
        {
            list.Add(item.Habilidade.Nome);
        }
        
        Console.WriteLine("---------------- INFORMAÇÕES ----------------");
        Console.WriteLine($"- Nome: {mascote.Nome.ToUpper()}");
        Console.WriteLine($"- Peso: {mascote.Peso}");
        Console.WriteLine($"- Altura: {mascote.Altura}");
        Console.WriteLine($"- Habilidades: {string.Join(", ", list).ToUpper()}\n");
        Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal...");
        Console.ReadKey();
    }
    public void SaberMaisSobreMascote(int opcao)
    {
        string nomeMascote = "";
        switch (opcao)
        {
            case 1: nomeMascote = "bulbasaur"; break;
            case 2: nomeMascote = "charmander"; break;
            case 3: nomeMascote = "squirtle"; break;
            case 4: nomeMascote = "pikachu"; break;
        }
        Mascote mascote = tamagotchiService.InvocarGet(nomeMascote);
        ExibirDescricaoCompletaMascote(mascote);
    }
    public void MenuAdotarMascoteSucesso()
    {
        ExibeLogo();
        Console.WriteLine("---------------- ADOTAR UM MASCOTE ----------------");
        Console.WriteLine("     Mascote adotado, o ovo está chocando...");
        Console.WriteLine("---------------------------------------------------");
    }
    public void Sair(string userName)
    {
        ExibeLogo();
        Console.WriteLine("---------------- SAINDO DO JOGO ----------------");
        Console.WriteLine($"{userName}, volte sempre! :)");
        Console.WriteLine("------------------------------------------------");
    }
}
