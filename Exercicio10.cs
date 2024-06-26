using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercício 10: Método com Parâmetros e Retorno 

//Descrição: Crie um método chamado CalcularMedia que receba três números decimais como parâmetros e retorne a média desses números. 

namespace MetodoParametros
{
    public class Exercicio10
    {
       public static void Main(string[] args)
        {
            decimal mediaFinal = CalculoDaMedia(19.9m, 89.6m, 29.1m);
            Console.WriteLine("A média final dos números citados é: " + mediaFinal);
        }

        static decimal CalculoDaMedia(decimal numero1, decimal numero2, decimal numero3)
        {
            return (numero1 + numero2 + numero3) / 3;
        }
 }  }
