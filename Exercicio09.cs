using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercício 9: Método com Parâmetros e Retorno 

//Descrição: Crie um método chamado ConcatenarStrings que receba duas strings como parâmetros e retorne a concatenação dessas duas strings. 

namespace MetodoParametros
{
    public class Exercicio09
    {
       public static void Main(string[] args)
        {
            string concatenacaoPalavra = ConcatenarStrings("Eu amo, ", "os meus gatos!");
            Console.WriteLine(concatenacaoPalavra);
        }

        static string ConcatenarStrings(string palavra1, string palavra2)
        {
            return palavra1+ palavra2;
        }
    }
}
