using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.fundamentos
{
    public class FormatandoNumeros
    {
        public static void Excecutar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("f1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));

            //podendo tambem atribuir duas casa deciamis adicionando "F2" 
            //mais podemos adicionar duas casas decimais com a formatação abaixo 
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo culture = new CultureInfo("pt-br");
            Console.WriteLine(valor.ToString("C3", culture));

        }
    }
}
