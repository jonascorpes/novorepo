//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace Aula_7 
{ 

   internal class Program 
   { 
    
      static void Main(string[] args) 
      { 
          Console.WriteLine("Cestinha!");
          string[] cestadefrutas = { "maçã", "banana", "uva", "manga" };
          
          for (int i = 0; i < cestadefrutas.Length; i++) 
          {
                Console.WriteLine(cestadefrutas[i]);
          }

            Console.WriteLine("Digite um dia da semana!");
            int dia = int.Parse(Console.ReadLine());
            switch(dia) 
            {
                case 1:
                    {
                        Console.WriteLine("Dom");
                    }
                    break;

                case 2: 
                    {
                        Console.WriteLine("Seg");
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("Ter");
                    }
                    break;

                case 4: 
                    {
                        Console.WriteLine("Qua");
                    }
                    break;

                case 5:
                    {
                        Console.WriteLine("Qui");
                    }
                    break;

                case 6:
                    {
                        Console.WriteLine("Sex");
                    }
                    break;

                case 7:
                    {
                        Console.WriteLine("Sab");
                    }
                    break;

                default:
                    Console.WriteLine("nenhum dia = (");
                    break;
            }
      }
   }
}