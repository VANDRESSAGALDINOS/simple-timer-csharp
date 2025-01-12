using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    private static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Escolha uma opção de quanto tempo deseja contar:");
        Console.WriteLine("S - Segundo");
        Console.WriteLine("M - Minuto");
        Console.WriteLine("E - Sair");
        Console.Write("Opção: ");

        string option = Console.ReadLine().ToUpper();

        if (option == "E") Environment.Exit(0);
  

        Console.Write("Digite o tempo que deseja contar (em números): ");

        if (!int.TryParse(Console.ReadLine(), out int time))
        {
            Console.WriteLine("Entrada inválida! Pressione qualquer tecla para tentar novamente.");
            Console.ReadKey();
            Menu();
            return;
        }

        switch (option)
        {
            case "M":
                Start(time * 60); 
                break;
            case "S":
                Start(time);
                break;
            default:
                Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente.");
                Console.ReadKey();
                Menu();
                break;
        }
    }

    private static void Start(int totalTimeInSeconds)
    {
        int currentTime = 0;
        while (currentTime < totalTimeInSeconds)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine($"Tempo: {currentTime} segundos");
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Timer finalizado!");
        Thread.Sleep(2500);
        Menu();
    }
}
