using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Exercício 8: Método com Parâmetros e Retorno 

//Descrição: Crie um método chamado CalcularFatorial que receba um inteiro positivo como parâmetro e retorne o fatorial desse número. 


namespace MetodoParametros
{
  public  class Exercicio08
    {
        public static void Main(string[] args)
        {
            int fatorial = CalculoDoFatorial(9);
            Console.WriteLine("O fatorial é: " + fatorial);
        }

        public static int CalculoDoFatorial(int numero)
        {
            if (numero == 0 || numero == 1)
            {
                return 1;
            }

            int resultado = 1;
            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
