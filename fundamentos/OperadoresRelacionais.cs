using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.fundamentos
{
    public class OperadoresRelacionais
    {
        public static void Excecutar()
        {
            double nota = 6.0;
            double notapraPassardeAno = 7.0;

            Console.WriteLine("passou de ano ? ", nota < 7); // ele não passou de ano 
            Console.WriteLine("não passou de ano" , notapraPassardeAno > nota); //ele não passou de ano Porque a nota para passar é maior que a nota do Aluno 
            Console.WriteLine("Como foi sua nota" , nota != notapraPassardeAno); //existe diferença 
            Console.WriteLine("Sua nota é igual a nota de corte ?" , nota == notapraPassardeAno); //então certamente ele passou de ano 
                                                                                                 
        }
    }
}
