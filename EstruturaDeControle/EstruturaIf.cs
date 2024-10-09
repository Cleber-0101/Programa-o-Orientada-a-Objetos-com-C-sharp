using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaIf
    {
        public static void Excecutar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N)");
            entrada = Console.ReadLine();

            if(entrada == "S" || entrada == "N")
                bomComportamento = true;

            if(nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de Honra");
            }
            
        }
    } 
}
