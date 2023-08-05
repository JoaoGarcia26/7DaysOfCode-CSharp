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
        Console.WriteLine("2 - Seu mascote");
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
        Console.WriteLine($"- Peso: {mascote.Peso}g");
        Console.WriteLine($"- Altura: {mascote.Altura}cm");
        Console.WriteLine($"- Habilidades: {string.Join(", ", list).ToUpper()}\n");
        Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal...");
        Console.ReadKey();
    }
    public void DashboardCompletoInteracao(Mascote mascote)
    {
        List<string> list = new();
        foreach (var item in mascote.Habilidades!)
        {
            list.Add(item.Habilidade.Nome);
        }
        ExibeLogo();
        Console.WriteLine("---------------- SEU MASCOTE ----------------");
        Console.WriteLine($"- Nome: {mascote.Nome.ToUpper()}");
        Console.WriteLine($"- Peso: {mascote.Peso}g");
        Console.WriteLine($"- Altura: {mascote.Altura}cm");
        Console.WriteLine($"- Habilidades: {string.Join(", ", list).ToUpper()}");
        Console.WriteLine($"- Fome: {mascote.VerificaFome()} | {mascote.Alimentacao}");
        Console.WriteLine($"- Humor: {mascote.VerificaHumor()} | {mascote.Humor}");
        Console.WriteLine($"- Sono: {mascote.VerificaSono()} | {mascote.Sono}\n");
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
        Thread.Sleep(4000);
    }

    public void MenuSeuMascote(string userName, Mascote mascote)
    {
        ExibeLogo();
        Console.WriteLine("---------------- SEU MASCOTE ----------------");
        Console.WriteLine($"{userName.ToUpper()}, voce deseja: \n");
        Console.WriteLine($"1 - Alimentar o {mascote.Nome.ToUpper()}");
        Console.WriteLine($"2 - Brincar com o {mascote.Nome.ToUpper()}");
        Console.WriteLine($"3 - Colocar o {mascote.Nome.ToUpper()} para durmir");
        Console.WriteLine($"4 - Saber como o {mascote.Nome.ToUpper()} está");
        Console.WriteLine("5 - Voltar\n");
        Console.Write("Digite a opção desejada: ");
    }
    public void MenuAlimentar(Mascote mascote)
    {
        ExibeLogo();
        Console.WriteLine("---------------- ALIMENTANDO ----------------");
        Console.WriteLine($"{mascote.Nome.ToUpper()} está comendo! NHAM NHAM NHAM");
        Console.WriteLine("---------------------------------------------");
        mascote.Alimentar();
        Thread.Sleep(4000);
    }
    public void MenuBrincar(Mascote mascote)
    {
        ExibeLogo();
        Console.WriteLine("---------------- BRINCANDO ----------------");
        Console.WriteLine($"{mascote.Nome.ToUpper()} está brincando! IIHHUUU!");
        Console.WriteLine("---------------------------------------------");
        mascote.Brincar();
        Thread.Sleep(4000);
    }
    public void MenuDormir(Mascote mascote)
    {
        ExibeLogo();
        Console.WriteLine("---------------- DORMINDO ----------------");
        Console.WriteLine($"{mascote.Nome.ToUpper()} está dormindo! zZzZZzZz...");
        Console.WriteLine("---------------------------------------------");
        mascote.Dormir();
        Thread.Sleep(4000);
    }
    public void Sair(string userName)
    {
        ExibeLogo();
        Console.WriteLine("---------------- SAINDO DO JOGO ----------------");
        Console.WriteLine($"{userName}, volte sempre! :)");
        Console.WriteLine("------------------------------------------------");
        Thread.Sleep(1000);
    }
}
