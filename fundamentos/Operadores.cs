using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.fundamentos
{
    public class Operadores
    {
        public static void Excecutar()
        {
            //preço com Desconto
            var preco = 1000;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("o preço final é " , totalComDesconto);

            //calculo do IMC 
            double peso = 93;
            double altura = 1.84;
            double imc = peso / (altura * altura);
            Console.WriteLine($"Imc é {imc}");

            //numero par ou impar 
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}" , par , par % 2);
        }

    }
}
