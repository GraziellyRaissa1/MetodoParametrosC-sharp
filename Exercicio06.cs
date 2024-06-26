using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercício 6: Método com Parâmetros e Retorno 

//Descrição: Crie um método chamado EhPar que receba um inteiro como parâmetro e retorne verdadeiro se o número for par e falso se for ímpar. 

namespace MetodoParametros
{
    internal class Exercicio06
    {
        public static void Main(string[] args)
        {
            bool resultado = NumPar(10);
            Console.WriteLine("O número é par? " + resultado);
        }

         public static bool NumPar(int numero)
        {
            return numero % 2 == 0;
        }
    }
}
