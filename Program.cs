// See https://aka.ms/new-console-template for more information
using System; // importanto funcinalidades básicas
public class SomaEMediaCompacta
{
    public static void Main (string[] args) // Dando nome ao projeto
    {
        // 1. Pergunta e Leitura da Quantidade
        Console.WriteLine("Quantos números você deseja somar e calcular a média?");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        // 2. Declaração e inicialização das variáveis
        double soma = 0;
        double numeroLido; // Declaração da variável fora do loop 
        Console.WriteLine($"n--- Digite os {quantidade} números ---");
        for (int i = 1; i <= quantidade; i++)
        {
            Console.WriteLine($"digite o {i}° número:"); // Use Console.Write para leitura mais limpa
            // Leitura e soma DENTRO do loop 
            numeroLido = Convert.ToDouble(Console.ReadLine());
            soma += numeroLido;

        }
        //4. Cálculo da Média
        double media = soma / quantidade;

        //5. Estrutura Condicional IF-ELSE Normal
        if (media > 1000)
        {
            Console.WriteLine("Média maior que 1000.");
        }
        else
        {
            Console.WriteLine("Média menor ou igual a 1000.");
        }

        //6. Impressão dos Resultados Finais
        Console.WriteLine("\n--- Resultado Finais ---");
        Console.WriteLine($"Total de números lidos: {quantidade}");
        Console.WriteLine($"A **SOMA** total dos números é: **{soma:F2}**"); // Usa a variável 'soma'
        Console.WriteLine($"A **MÉDIA** dos números Lidos é: **{media:F2}**"); // Usa a variável 'media'
    }

}

