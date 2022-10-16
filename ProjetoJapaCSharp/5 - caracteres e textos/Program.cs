using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - caracteres e textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        string primeirafrase = @"alura- Cursos disponiveis: 
- Go 
- C# 
- java 
- javaScript 
- Html 
- Css";
        Console.WriteLine(primeirafrase);

        Console.WriteLine("tecle enter para sair");
        Console.ReadLine();
    }
}