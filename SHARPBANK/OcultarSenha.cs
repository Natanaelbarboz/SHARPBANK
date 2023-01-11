using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARPBANK
{
    class TesteSenha
    {
        public string TesteOcultarSenha()
        {
            

            string entrada = string.Empty;
            ConsoleKey senha;
            do
            {
                var SenhaInformada = Console.ReadKey(intercept: true);
                senha = SenhaInformada.Key;

                if (senha == ConsoleKey.Backspace && entrada.Length > 0)
                {
                    Console.Write("\b \b");
                    entrada = entrada[0..^1];
                }
                else if (!char.IsControl(SenhaInformada.KeyChar))
                {
                    Console.Write("*");
                    entrada += SenhaInformada.KeyChar;
                }
            } while (senha != ConsoleKey.Enter);
            Console.WriteLine();
            return entrada;

        }

    }
}
