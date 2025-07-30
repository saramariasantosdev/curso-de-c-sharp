ContaBancaria conta = new ContaBancaria();

conta.numeroIndicador = "123456";
conta.titular = "João Silva";
conta.saldo = 1000;
conta.senha = "senhaSegura";

// Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
// Console.WriteLine($"Titular: {conta.titular}");
// Console.WriteLine($"Saldo: {conta.saldo}");

conta.ExibirInformações();

