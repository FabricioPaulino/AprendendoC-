using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Calcula Poupança 0.2");

        double investimento = 1000;

        /*
        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("no mes " + mes + " você tem R$" + investimento);


            mes += 1;
        }
        */

        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("no mes " + mes + " você tem R$" + investimento);
        }

        Console.WriteLine("tecle enter para fechar");
        Console.ReadLine();
    }
}
