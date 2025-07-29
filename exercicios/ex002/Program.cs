// Criar uma lista vazia
List<string> linguagens = new List<string>();

// Adiicionar itens na lista
linguagens.Add("C#");
linguagens.Add("Java");
linguagens.Add("Javascript");

// Exibir a linguagem de programação C#
Console.WriteLine($"Linguagem: {linguagens[0]}");

// Exibir a linguagem de programação escolhida pelo usuário
Console.Write("Informe a posição desejada: ");
string posicao = Console.ReadLine()!;

Console.WriteLine($"Linguagem escolhida: {linguagens[int.Parse(posicao)]}");
