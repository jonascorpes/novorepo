using System;

namespace Aula5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //if (1 > 2) 
            //{
            //    Console.WriteLine("1 > 2");
            //    Console.WriteLine("");

            //}
            //else if (2 == 3) 
            //{
            //    Console.WriteLine("2 == 3");
            //}
            //else if (1 == 1) 
            //{ 

            //}

            //    Console.WriteLine("Bem vindo a loja!");
            //    Console.WriteLine("Insira uma fruta: ");
            //    string fruta = Console.ReadLine();
            //    Console.WriteLine("Insira uma quantidade: ");
            //    int Quantidade = int.Parse
            //}   

            //Console.WriteLine("!!!!!Penalidade!!!!!");
            //string minhaPenalidade = Console.ReadLine();
            //int contador = 0;

            //while (contador <= 100) 
            //{

            //    Console.WriteLine(minhaPenalidade + " - " + contador);

            //    contador++;

            //}
            //Console.ReadKey();

            Console.WriteLine("Insira o valor mínimo: ");
            int minimo = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor limite: ");
            int maximo = int.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: ");

            while (minimo <= maximo) 
            { 
            
                if (minimo % 2 == 2) 
                {
                    Console.WriteLine("Resultado valor: " + minimo);
                }

              minimo++;
            }

        }

    }
}