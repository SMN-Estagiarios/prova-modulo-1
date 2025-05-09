using System;

class Program
{
    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("=== MENU DE QUESTÕES ===");
            Console.WriteLine("1. Soma dos N primeiros números naturais");
            Console.WriteLine("2. Verificar se um número é primo");
            Console.WriteLine("3. Encontrar o maior e menor número de uma sequência");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Questao1();
                    break;
                case 2:
                    Questao2();
                    break;
                case 3:
                    Questao3();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine();

        } while (opcao != 0);
    }

    static void Questao1()
    {
        Console.Write("Digite um número N: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= n; i++)
            sum += i;
        
        System.Console.WriteLine($"\nA SOMA E: {sum}");
    }

    static void Questao2()
    {
        Console.Write("Digite um número para verificar se é primo: ");
        int num = int.Parse(Console.ReadLine());
        if (num <= 2)
        {
            System.Console.WriteLine("\nNAO EH PRIMO");
            return;
        }
        for (int i = 3; i <= num/2; i++)
        {
            if ((num % i) == 0)
            {
                System.Console.WriteLine("\nNAO EH PRIMO");
                return;
            }
        }
        System.Console.WriteLine("\nEH PRIMO");
        return;
    }

    static void Questao3()
    {
        Console.Write("Quantos números deseja inserir? ");
        int qtd = int.Parse(Console.ReadLine());

        int maior = int.MinValue;
        int menor = int.MaxValue;
        int numeroEntrada;
        for (int i = 0; i < qtd; i++)
        {
            System.Console.WriteLine("Digite o numero:");
            numeroEntrada = int.Parse(Console.ReadLine());

            if (numeroEntrada > maior)
                maior = numeroEntrada;
            
            if (numeroEntrada < menor)
                menor = numeroEntrada;
        }

        Console.WriteLine($"Maior número: {maior}");
        Console.WriteLine($"Menor número: {menor}");
    }
}
