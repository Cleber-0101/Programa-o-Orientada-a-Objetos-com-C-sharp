using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.fundamentos
{
    public class NotacaoPonto
    {
        public static void Excecutar()
        {
            var saudacao = "Ola".ToUpper().Insert(3 , " Cleber").Replace("ola" , ("ain cigarrinho"));
            Console.WriteLine(saudacao.Length);

            string nomeEstaVazio = null;
            Console.WriteLine(nomeEstaVazio?.Length);
        }
    }
}
