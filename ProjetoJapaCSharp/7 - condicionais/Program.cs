using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        

        if(idadeJoao >= 18)
        {
            Console.WriteLine("seja bem vindo!");
        }
        else
        {
            if(quantidadePessoas > 1)
            {
                Console.WriteLine("sejam bem vindos!");
            }
            else
            {
                Console.WriteLine("infelizmente, você não pode entrar");
            }
        }

        Console.WriteLine("tecle enter para fechar ...");
        Console.ReadLine();
        
    }
}
