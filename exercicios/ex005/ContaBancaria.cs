// Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.

class ContaBancaria
{
    public string numeroIndicador = "";
    public string titular = "";
    public int saldo;
    public string senha = "";

    public void ExibirInformações()
    {
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Saldo: {saldo}");
    }
}