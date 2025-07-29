// Criar um programa que gerencie o estoque de uma loja. 

// Utilize um dicionário para armazenar produtos e suas quantidades em estoque
Dictionary<string, int> estoqueDeProdutos = new Dictionary<string, int>();

estoqueDeProdutos.Add("Caderno", 200);
estoqueDeProdutos.Add("Mochila", 150);
estoqueDeProdutos.Add("Notebook", 90);

Console.Write("Digite o nome do produto que deseja saber sua quantidade no estoque: ");
string produto = Console.ReadLine()!;
int quantidade = estoqueDeProdutos[produto];

if (estoqueDeProdutos.ContainsKey(produto))
{
    Console.WriteLine($"A quantidade do produto {produto} é {quantidade}");
}
else
{
    Console.WriteLine($"´Produto {produto} não encontrado!");
}