// Criar uma lista de bandas vazia
List<string> bandasFavoritas = new List<string>();

// e adicionar suas bandas prediletas em seguida.
bandasFavoritas.Add("Queen");
bandasFavoritas.Add("Pink Floyd");
bandasFavoritas.Add("The Beatles");
bandasFavoritas.Add("Aerosmith");

// Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.
foreach (string banda in bandasFavoritas)
{
    Console.WriteLine($"Banda {banda}");
}

