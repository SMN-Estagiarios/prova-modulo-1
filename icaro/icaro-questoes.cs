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
                    SomaNumeros();
                    break;
                case 2:
                    EncontraNumeroPrimo();
                    break;
                case 3:
                    EncontraMaiorMenor();
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

    static void SomaNumeros()
    {
        // TODO: Solicite um número N ao usuário e calcule a soma dos N primeiros números naturais
        Console.Write("Digite um número N: ");
        int n = int.Parse(Console.ReadLine());

        // O aluno deve implementar a soma
        int soma = 0;
        for(int i = 1; i <= n; i++)
        {
            soma += i;
        }
        Console.WriteLine($"SOMA: {soma}");
    }

    static void EncontraNumeroPrimo()
    {
        // TODO: Solicite um número ao usuário e verifique se ele é primo
        Console.Write("Digite um número para verificar se é primo: ");
        int num = int.Parse(Console.ReadLine());

        // O aluno deve verificar se o número é primo
        int contPrimo = 0;
        for(int i = 1; i <= num; i++)
        {
            if(num % i == 0)
            {
                contPrimo++;
            }
        }
        if(contPrimo == 2 || num == 1)
        {
            Console.WriteLine($"Número {num} é primo.");
        }
        else
        {
            Console.WriteLine($"Número {num} não é primo.");
        }
    }

    static void EncontraMaiorMenor()
    {
        // Desafio: Solicite N números ao usuário e encontre o maior e o menor deles
        Console.Write("Quantos números deseja inserir? ");
        int qtd = int.Parse(Console.ReadLine());

        int maior = int.MinValue;
        int menor = int.MaxValue;

        // Escreva o que falta aqui
        for(int i = 1; i <= qtd; i++)
        {
            Console.Write($"Insira o {i}º número: ");
            int num = int.Parse(Console.ReadLine());
            if(i == 1)
            {
                menor = num;
                maior = num;
            }
            else
            {
                if (num < menor)
                {
                    menor = num;
                }
                else if (num > maior)
                {
                    maior = num;
                }
            }
        }

        Console.WriteLine($"Maior número: {maior}");
        Console.WriteLine($"Menor número: {menor}");
    }
}
