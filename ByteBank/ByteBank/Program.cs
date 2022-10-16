using ByteBank.ContasCorrente;
using ByteBank.Titulares;
using System.Reflection.Metadata.Ecma335;

cliente conta1 = new cliente();
conta1.Nome = "Andre Pinheiro";
conta1.Cpf = "123456789-44";
conta1.Profissao = "Medico";


ContaCorrente contaDoAndre = new ContaCorrente(conta1, "1010-X", 15, "Andre Pinheiro");
Console.WriteLine(contaDoAndre.Conta);
//contaDoAndre.Numero_agencia = 15;
//contaDoAndre.Conta = "1010-X";
//contaDoAndre.SetSaldo(100);

//Console.WriteLine("Titular da conta = " + contaDoAndre.Titular.Nome);
//Console.WriteLine("Cpf do Titular = " + contaDoAndre.Titular.Cpf);
//Console.WriteLine("Profisão = " + contaDoAndre.Titular.Profissao);
//Console.WriteLine($"Numero da Agencia: {contaDoAndre.Numero_agencia}");
//Console.WriteLine($"Conta: {contaDoAndre.Conta}");
//Console.WriteLine($"Saldo R$ " + contaDoAndre.GetSaldo());


////Conta que vai receber o saque 
//ContaCorrente contaDaMaria = new ContaCorrente(22, "1010-5");
//contaDaMaria.Titular = new cliente();

//contaDaMaria.Titular.Nome = "Maria sousa";
//contaDaMaria.Titular.Cpf = "932145645";
//contaDaMaria.Titular.Profissao = "pedreira";
////contaDaMaria.Numero_agencia = 22;
////contaDaMaria.Conta = "1010-5";
//contaDaMaria.SetSaldo(350);


////mostra as informações da conta
//Console.WriteLine("Titular da conta = " + contaDaMaria.Titular.Nome);
//Console.WriteLine("Cpf do Titular = " + contaDaMaria.Titular.Cpf);
//Console.WriteLine("Profisão = " + contaDaMaria.Titular.Profissao);
//Console.WriteLine($"Conta: {contaDaMaria.Conta}");
//Console.WriteLine($"Saldo R$ " + contaDaMaria.GetSaldo());


//contaDoAndre.Depositar(100);

//Console.WriteLine($"Saldo do Andre pos deposito: R$ " + contaDoAndre.GetSaldo());

//if (contaDoAndre.Sacar(300) == true)
//{
//    Console.WriteLine($"Saldo do Andre pos saque: R$ " + contaDoAndre.GetSaldo());
//}
//else
//{
//    Console.WriteLine("saldo insuficiente");
//}

//contaDoAndre.Transferir(50, contaDaMaria);

//Console.WriteLine($"Saldo R$ " + contaDoAndre.GetSaldo());
//Console.WriteLine($"Saldo R$ " + contaDaMaria.GetSaldo());


//ContaCorrente contaDaRosangela = new ContaCorrente(245, "2020-z");

//ContaCorrente contaDaPamela= new ContaCorrente(222, "2120-x");

//ContaCorrente contaDaAngela = new ContaCorrente(245, "2909-z");

////Mostra a quantidade de contas existentes
//Console.WriteLine("A quantidade de Contas criadas atualmente é de = " + ContaCorrente.NumeroTotalDeContas);