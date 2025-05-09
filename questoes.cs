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
                case 4:
                    Questao4();
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
        // TODO: Solicite um número N ao usuário e calcule a soma dos N primeiros números naturais
        Console.Write("Digite um número N: ");
        int n = int.Parse(Console.ReadLine());

        // O aluno deve implementar a soma
    }

    static void Questao2()
    {
        // TODO: Solicite um número ao usuário e verifique se ele é primo
        Console.Write("Digite um número para verificar se é primo: ");
        int num = int.Parse(Console.ReadLine());

        // O aluno deve verificar se o número é primo
    }

    static void Questao3()
    {
        // Desafio: Solicite N números ao usuário e encontre o maior e o menor deles
        Console.Write("Quantos números deseja inserir? ");
        int qtd = int.Parse(Console.ReadLine());

        int maior = int.MinValue;
        int menor = int.MaxValue;

        // Escreva o que falta aqui

        Console.WriteLine($"Maior número: {maior}");
        Console.WriteLine($"Menor número: {menor}");
    }
}
