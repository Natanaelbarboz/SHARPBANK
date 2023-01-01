using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARPBANK
{


    internal class DetalheDaConta
    {
        public static void DetalhedaContaCliente(List<string> CPF, List<string> Nome, List<string> Senha, List<double> Saldo)
        {
            Console.WriteLine();
            Console.Write("                     INFORME O SEU CPF: ");
            string entradaCPF = Console.ReadLine();

            while (entradaCPF == "")
            {
                Console.Clear();
                Front.SegundaTelaDeInicio();
                Console.WriteLine();
                Console.Write("                     INFORME O SEU CPF: ");
                entradaCPF = Console.ReadLine();

            }

            int j = 0;

            for (int i = 0; i < CPF.Count; i++)
            {

                if (CPF[i] == entradaCPF)
                {
                    j++;
                    Console.Clear();
                    Front.SegundaTelaDeInicio();
                    Console.WriteLine($"                     CPF: {CPF[i]}  \n");
                    Console.WriteLine($"                     NOME: {Nome[i]}  \n");
                    Console.WriteLine($"                     SALDO: R$ {Saldo[i]:f2}  \n");

                    Console.Write("                     APERTE QUALQUER TECLA PARA CONTINUAR");
                    Console.ReadKey();
                    Console.Clear();
                    Front.SegundaTelaDeInicio();
                    Console.WriteLine();
                    Front.SubMenuCliente(CPF, Nome, Senha, Saldo);

                }


            }
            if (j == 0)
            {
                Console.WriteLine("                     CPF NÃO LOCALIZADO\n");
                Console.WriteLine("                     PARA SUA SEGURANÇA A SESSÃO ESTÁ SENDO ENCERRADA\n");
                Console.WriteLine("                     AGRADECEMOS A SUA COMPREENÇÃO\n");
                Console.Write("                     APERTE QUALQUER TECLA PARA CONTINUAR");
                Console.ReadKey();
                Console.Clear();

            }
        }

    }
}
