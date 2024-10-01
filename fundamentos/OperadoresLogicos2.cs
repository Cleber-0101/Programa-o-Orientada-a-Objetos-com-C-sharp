using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.fundamentos
{
    public  class OperadoresLogicos2
    {
        public static void Excecutar()
        {
            //operadores logicos
            var trabalho1 = true;
            var trabalho2 = true;


            //operador onde duas condiçoes precisam ser verdadeiras 
            var comprouTV50 =  trabalho1 && trabalho2;
            Console.WriteLine("Comprou a tv ?" ,  comprouTV50);


            //operador onde umas das condiçoes precisam ser verdadeiras 
            var comprouTV1 =  trabalho1 || trabalho2;
            Console.WriteLine("Comprou  ?" , comprouTV1);

            //operador que inverte a condição se for verdadeira fica falso e ser for falso fica verdade
            var compraDeTv = trabalho1 ^ trabalho2;
            Console.WriteLine("Comrprou" ,!compraDeTv);

        }
    }
}
