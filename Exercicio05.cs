using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercício 5: Método com Parâmetros e Retorno 

//Descrição: Crie um método chamado MaiorNumero que receba dois inteiros como parâmetros e retorne o maior entre eles. 


namespace MetodoParametros
{
    public class Exercicio05
    {
        public static void Main(string[] args)
        {
            int MaiorNumero = Maior(1700, 240);
            Console.WriteLine("O maior número é: " + MaiorNumero);
        }

        public static int Maior(int Numero1, int Numero2)
        {
            return Numero1 > Numero2? Numero1 : Numero2;
        }
    }
}
