using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Calcula Poupança apenas");

        double investimento = 1000;

        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("no mes " + mes + " você tem R$" + investimento);


            mes += 1;     
        }

        Console.WriteLine("tecle enter para fechar");
        Console.ReadLine();
    }
}
