using System;
using System.Collections.Generic;

public class ListaDeLinguagens
{
    public static void Main(string[] args)
    {
        // Desafio 2
        List<string> linguagens = new List<string>();

        linguagens.Add("C#");
        linguagens.Add("Java");
        linguagens.Add("Javascript");

        // Desafio 3
        Console.WriteLine($"Linguagem: {linguagens[0]}");

        // Desafio 4
        Console.Write("Informe a posição desejada: ");
        string posicao = Console.ReadLine()!;

        Console.WriteLine($"Linguagem escolhida: {linguagens[int.Parse(posicao)]}");
    }
}
