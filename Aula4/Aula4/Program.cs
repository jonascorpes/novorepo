using System;

namespace Aula4;


class Program
{
    static void Main(string[] args) 
    {
        Console.Write("digite um número");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
            Console.WriteLine("número par");
        else
            Console.WriteLine("número impar");

        Console.ReadKey();
    
    
    }
    
}

