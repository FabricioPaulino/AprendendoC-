using System;
class Programa
{
    static void Main(string[] args)
    {
        double salario = 3.2;
        Console.WriteLine(salario);

        int salariointeiro = (int)salario;
        Console.WriteLine(salariointeiro);

        long x = 2000000000000000000;
        Console.WriteLine(x);

        short y = 15000;
        Console.WriteLine(y);

        float altura = 1.68f;
        Console.WriteLine(altura);

        Console.WriteLine("tecle enter para fechar...");
        Console.ReadLine();

        int idade = 3 * 10;
        Console.WriteLine("A idade de Marcos é " + idade + "!");
    }
}