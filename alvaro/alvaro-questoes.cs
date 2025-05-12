using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;


class Program
{
    static void Main()
    {
        int opcao;
        do
        {
            Console.Clear();
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
                    SomaNumero();
                    break;
                case 2:
                    NumeroPrimo();
                    break;
                case 3:
                    NumeroMaiorMenor();
                    Console.ReadKey();
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

    static void SomaNumero()
    {
        // TODO: Solicite um número N ao usuário e calcule a soma dos N primeiros números naturais
        Console.Write("Digite um número N: ");
        int n = int.Parse(Console.ReadLine());
        int soma = 0;

        if (n >= 0)
        {
            for (int i = 0; i <= n; i++)
            {
                soma += i;
            }
            Console.Write($"A soma é: {soma}");
        }
        else
        {
            Console.WriteLine($"{n} Não é uma opção válida!");
        }
    }

    static void NumeroPrimo()
    {
        // TODO: Solicite um número ao usuário e verifique se ele é primo
        Console.Write("Digite um número para verificar se é primo: ");
        int num = int.Parse(Console.ReadLine());

        // O aluno deve verificar se o número é primo
        int contadorPrimo = 0;
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                contadorPrimo++;
            }
        }
        if (contadorPrimo == 2)
        {
            Console.WriteLine($"{num} É Primo!");
        }
        else
        {
            Console.WriteLine($"{num} Não é Primo!");
        }
    }

    static void NumeroMaiorMenor()
    {
        List<int> numeros = new List<int>();

        // Desafio: Solicite N números ao usuário e encontre o maior e o menor deles

        Console.Write("Quantos números deseja inserir? ");
        int qtd = int.Parse(Console.ReadLine());
        int i;

        for (i = 0; i < qtd; i++)
        {
            Console.WriteLine("Digite um número");
            int num = int.Parse(Console.ReadLine());
            numeros.Add(num);
        }
        if (numeros.Count == qtd)
        {
            Console.WriteLine($"Maior número: {numeros.Max()}");
            Console.WriteLine($"Menor número: {numeros.Min()}");
        }
    }
}
