using _7DaysOfCode_C_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DaysOfCode_C_.View;

internal class TamagotchiView
{
    public static void ExibeLogo()
    {
        Console.WriteLine(@"
                ████████╗░█████╗░███╗░░░███╗░█████╗░░██████╗░░█████╗░████████╗░█████╗░██╗░░██╗██╗
                ╚══██╔══╝██╔══██╗████╗░████║██╔══██╗██╔════╝░██╔══██╗╚══██╔══╝██╔══██╗██║░░██║██║
                ░░░██║░░░███████║██╔████╔██║███████║██║░░██╗░██║░░██║░░░██║░░░██║░░╚═╝███████║██║
                ░░░██║░░░██╔══██║██║╚██╔╝██║██╔══██║██║░░╚██╗██║░░██║░░░██║░░░██║░░██╗██╔══██║██║
                ░░░██║░░░██║░░██║██║░╚═╝░██║██║░░██║╚██████╔╝╚█████╔╝░░░██║░░░╚█████╔╝██║░░██║██║
                ░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░╚═╝░╚═════╝░░╚════╝░░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚═╝" + "\n");
    }
    public static void MenuLogin()
    {
        Console.WriteLine("Insira seu nome: ");
    }
    public static void MenuPrimario(string username)
    {
        Console.WriteLine("---------------- MENU ----------------");
        Console.WriteLine($"{username.ToUpper()}, escolha uma opção: ");
        Console.WriteLine("1 - Adotar um mascote");
        Console.WriteLine("2 - Ver seus mascotes");
        Console.WriteLine("3 - Sair");
        Console.Write("Digite a opção desejada: ");
    }
    public static void MenuAdotarMascote(string username)
    {
        string listaMascotes = "1 - Bulbasaur\r\n    2 - Chamander\r\n    3 - Squirtle\r\n    4 - Pikachu";
        Console.WriteLine("---------------- ADOTAR UM MASCOTE ----------------");
        Console.WriteLine($"{username.ToUpper()}, escolha uma espécie:");
        Console.WriteLine($"{listaMascotes}");
        Console.Write("Digite a opção desejada: ");
    }
    public static void MenuMascoteSelecionado(string username, int opcao)
    {
        string nomeMascote = "";
        switch (opcao)
        {
            case 1: nomeMascote = "Bulbasaur"; break;
            case 2: nomeMascote = "Chamander"; break;
            case 3: nomeMascote = "Squirtle"; break;
            case 4: nomeMascote = "Pikachu"; break;
        }
        Console.WriteLine($"---------------- {nomeMascote} ----------------");
        Console.WriteLine($"{username.ToUpper()}, voce deseja: ");
        Console.WriteLine($"1 - Saber mais sobre {nomeMascote}");
        Console.WriteLine($"2 - Adotar {nomeMascote}");
        Console.WriteLine("3 - Sair");
        Console.Write("Digite a opção desejada: ");
    }
    public static void ExibirDescricaoMascote(Mascote mascote)
    {
        List<string> list = new();
        foreach (var item in mascote.Habilidades!)
        {
            list.Add(item.Habilidade.Nome);
        }
        Console.WriteLine($"Nome Pokemon: {mascote.Nome.ToUpper()} \nAltura: {mascote.Altura} \nPeso: {mascote.Peso} \nHabilidades: " +
            $"{string.Join(", ", list).ToUpper()} ");
    }
    public static void MenuAdotarMascote()
    {
        Console.WriteLine("---------------- ADOTAR UM MASCOTE ----------------");
        Console.WriteLine("Mascote adotado, o ovo está chocando...");
    }
}
