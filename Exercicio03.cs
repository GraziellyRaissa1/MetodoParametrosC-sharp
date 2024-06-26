using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercício 3: Método com Parâmetros e Retorno 

//Descrição: Crie um método chamado Somar que receba dois inteiros como parâmetros e retorne a soma desses dois números. 

namespace MetodoParametros
{
    public class Exercicio03
    {
        public static void Main(string[] args)
        {
            int resultadoSoma = SomaNumero(670, 3009);
            Console.WriteLine("A soma é: " + resultadoSoma);
        }

        public static int SomaNumero(int Numero01, int Numero02)
        {
            return Numero01 + Numero02;
        }
    }
}
