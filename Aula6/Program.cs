using System;

namespace Aula_6
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("!!!Simulação!!!");
            Console.WriteLine("Solicite um valor: ");
            double valorEmprestimo = double.Parse(Console.ReadLine());
            if (valorEmprestimo >= 10 && valorEmprestimo <= 100)
            {

                Console.WriteLine("Insira uma taxa: ");
                double valorTaxa = double.Parse(Console.ReadLine());
                string path = $@"C:\Users\jonaa\source\repos\Aula6\{valorEmprestimo}-{valorTaxa}.txt";
                if (File.Exists(path)) 
                { 
                   using (StreamWriter sw = File.CreateText(path)) 
                   {
                        sw.WriteLine("=====Início da Simulação no dia-a-dia=====");
                        
                   }
                }
                if (valorTaxa >= 1 && valorTaxa <= 5)
                {
                    int contadorMes = 1;

                    double montanteEmprestimoMes = valorEmprestimo;
                    while (contadorMes <= 30)
                    {
                        montanteEmprestimoMes = montanteEmprestimoMes + (montanteEmprestimoMes * (valorTaxa / 100));
                        contadorMes++;
                    }

                    int contadorAno = 1;

                    double montanteEmprestimoAno = valorEmprestimo;
                    while (contadorAno <= 12)
                    {
                        montanteEmprestimoAno = montanteEmprestimoAno + (montanteEmprestimoAno * (valorTaxa / 100));
                        contadorAno++;
                    }

                    Console.WriteLine("Seu empréstimo de " + valorEmprestimo + " com a taxa de" + valorTaxa + " (Diária) no final de um mês acumula o montante de " + Math.Round(montanteEmprestimoMes, 2) + " a pagar!");
                    Console.WriteLine("Seu empréstimo de " + valorEmprestimo + " com a taxa de" + valorTaxa + " (Mensal) no final de um mês acumula o montante de " + Math.Round(montanteEmprestimoAno, 2) + " a pagar!");
                }
                else
                {
                    Console.WriteLine("Não é possível realizar essa simulação!");
                }
            }
            else
            {
                Console.WriteLine("Não é possível realizar essa simulação!");
            }
        }
    }
}