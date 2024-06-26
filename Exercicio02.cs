using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Exercício 2: Método com Parâmetro sem Retorno 

//Descrição: Crie um método chamado ImprimirMensagem que receba uma string como parâmetro e imprima essa mensagem na tela. 


namespace MetodoParametros
{
   public class Exercicio02
    {
     
        public static void Main(string[] args)
        {
            Mensagem(" Parabéns, agora voocê faz parte do tive Picpay como Desenvolvedor Back-End Junior!");
        }

        public static void Mensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }

}

