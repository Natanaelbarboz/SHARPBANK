using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARPBANK
{
    class ReutilizarCPFCliente
    {
        public static string ReutilizarCPF()
        {
            Console.Write("                     DIGITE SEU CPF SEM PONTO OU VIRGULA: ");
            string CPF = Console.ReadLine();

            while (CPF == "" || CPF.Length < 11 || CPF.Length > 11)
            {
                Console.Clear();
                Console.WriteLine("CPF INVÁLIDO");
                Console.Write("DIGITE SEU CPF SEM PONTO OU VIRGULA: ");
                CPF = Console.ReadLine();
            }

            return CPF;
        }
    }
}
