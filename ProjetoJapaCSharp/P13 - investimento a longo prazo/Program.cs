using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Investindo a longo prazo");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        for(int ano = 1; ano <= 5; ano++)
        {
            for(int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }

            fatorRendimento += 0.001;
        }
        
        Console.WriteLine("Depois de 5 anos você tera " + investimento);

        Console.WriteLine("tecle enter para fechar");
        Console.ReadLine();
    }
}
