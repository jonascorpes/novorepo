using System;

namespace Aula7 
{ 

   internal class Program 
   { 
      static void Main(string[] args) 
      {
            Console.WriteLine("!!!Simulação!!!");
            Console.WriteLine("Solicite um valor");
            double valorEmprestimo = double.Parse(Console.ReadLine());

            if (valorEmprestimo >= 10 && valorEmprestimo <= 100)
            {
                Console.WriteLine("Insira uma taxa: ");
                double valorTaxa = double.Parse(Console.ReadLine());
                if (valorTaxa >= 1 && valorTaxa <= 5)
                {
                    double montanteEmprestimoMes = valorEmprestimo;
                    Console.WriteLine(" ");
                    Console.WriteLine("!!!Resultado da simulação!!!");
                    Console.WriteLine(" ");

                    for (int i = 1; i <= 30; i++)
                    {
                        montanteEmprestimoMes = montanteEmprestimoMes + (montanteEmprestimoMes * (valorTaxa / 100));
                        Console.WriteLine(String.Format("Valor de montante calculado para o dia {0} : R$ {1}", i, Math.Round(montanteEmprestimoMes, 2)));
                    }

                    Console.WriteLine("Seu emprestimo de " + valorEmprestimo + " com a taxa de" + valorTaxa + " (Diária) no final de um mês acumula o montante de " + Math.Round(montanteEmprestimoMes, 2) + " a pagar!");
                    Console.WriteLine(" ");

                    double montanteEmprestimoAno = valorEmprestimo;
                    string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

                    for (int i = 0; i < 12; i++)
                    {
                        montanteEmprestimoAno = montanteEmprestimoAno + (montanteEmprestimoAno * (valorTaxa / 100));
                        Console.WriteLine(String.Format("Valor de montante calculado para o mês {0} : R$ {1}", meses[i], Math.Round(montanteEmprestimoAno, 2)));

                    }

                    Console.WriteLine("Seu empréstimo de " + valorEmprestimo + " com a taxa de " + valorTaxa + " (mensal) no final de um ano acumula o montante de " + Math.Round(montanteEmprestimoAno, 2) + " a pagar!");
                }
            }
            else
                Console.WriteLine("Não é possível realizar essa simulação!");
      }
     
          
   }

}
