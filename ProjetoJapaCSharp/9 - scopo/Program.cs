using System;
using System.Xml;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 9 - condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;


        string textoAdcional;


        if(acompanhado == true)
        {
            textoAdcional = "João está acompanhado";
        }
        else
        {
            textoAdcional = "João não está acompnhado";
        }


        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdcional);
            Console.WriteLine("eai safada, seja bem vinda!");
        }
        else
        {
            Console.WriteLine("infelizmente, você não pode entrar");
        }

        Console.WriteLine("tecle enter para fechar ...");
        Console.ReadLine();

    }
}

