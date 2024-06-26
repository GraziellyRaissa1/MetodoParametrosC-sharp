using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercício 4: Método com Parâmetros e Retorno 

//Descrição: Crie um método chamado Multiplicar que receba dois inteiros como parâmetros e retorne o produto desses dois números. 

namespace MetodoParametros
{
    public class Exercicio04
    {
       public static void Main(string[] args)
        {
            int resultadoMultiplicacao = MultiplicaNumero(400, 70);
            Console.WriteLine("O produto é: " + resultadoMultiplicacao);
        }

        public static int MultiplicaNumero(int Numero01, int Numero02)
        {
            return Numero01 * Numero02;
        }
    }
}
