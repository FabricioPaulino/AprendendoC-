using System;
class Programa
{
    static void Main(string[] args)
    {
      for(int numerodivisiveis = 0; numerodivisiveis <= 100; numerodivisiveis++)
       {

                if (numerodivisiveis % 3 == 0)
                {
                    Console.Write(numerodivisiveis);
                }
       }


      for (int i = 3; i < 100; i += 3)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();

    }
}