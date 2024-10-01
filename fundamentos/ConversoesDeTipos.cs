using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.fundamentos
{
    public  class ConversoesDeTipos
    {
        public static void Excecutar()
        {

            //conversão implicita
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            //conversão explicita mais conhecida como casting
            double nota = 9.7;
            int notaTruncada = (int) nota;
            Console.WriteLine("Nota truncada " , notaTruncada);

            //conversão de string pra numero
            Console.WriteLine("Digite sua idade:");
            string idadeString = Console.ReadLine();
            int idadeinteiro = int.Parse(idadeString);
            Console.WriteLine("idade inserida:  {0}" , idadeinteiro);

            //outra forma de conversão é usando o Convert 
            idadeinteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}" , idadeinteiro);

            //Outra forma mais segura de conversão é usando o TryParse
            Console.WriteLine("Digite um numero");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);  



        }
    }
}
