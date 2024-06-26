using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercício 7: Método sem Parâmetros com Retorno 

//Descrição: Crie um método chamado ObterDataAtual que não receba parâmetros e retorne a data atual como uma string no formato "dd/MM/yyyy". 


namespace MetodoParametros
{
    internal class Exercicio07
    {
       public static void Main(string[] args)
        {
            string dataAtual = DescobrirDataAtual();
            Console.WriteLine("A data atual é: " + dataAtual);
        }

        static string DescobrirDataAtual()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
