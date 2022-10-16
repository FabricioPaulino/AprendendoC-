using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;

        if(salario > 1900 && salario < 2800)
        {
            Console.WriteLine("Sua aliquota é de 7,5%");
            Console.WriteLine("Valor deduzido em 142 R$");
        }
        if (salario > 2800.1 && salario < 3751)
        {
            Console.WriteLine("Sua aliquota é de 15%");
            Console.WriteLine("Valor deduzido em 350 R$");
        }
        if (salario > 3751.1 && salario < 4664)
        {
            Console.WriteLine("Sua aliquota é de 22.5%");
            Console.WriteLine("Valor deduzido em 350 R$");
        }

        Console.WriteLine("Para sair pressione Enter...");
        Console.ReadLine();
    }
}