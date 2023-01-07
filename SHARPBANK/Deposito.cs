using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARPBANK
{
    internal class Depositar
    {
        public static void Deposito(List<string> CPF, List<string> Nome, List<string> Senha, List<double> Saldo, List<int> Conta, List<int> CV)
        {
            Console.WriteLine();
            Console.Write("                     INFORME SEU CPF: ");
            string entradaCPF = Console.ReadLine();
            while (entradaCPF == "")
            {
                Console.Clear();
                Telas.SegundaTelaDeInicio();
                Console.Write("                     INFORME SEU CPF: ");
                entradaCPF = Console.ReadLine();
            }
            int controle = 0;

            for (int i = 0; i < CPF.Count; i++)
            {
                if (entradaCPF == CPF[i])
                {
                    controle++;
                    Console.WriteLine();

                    Console.Write($"                     {Nome[i]} INFORME O VALOR QUE DESEJA DEPOSITAR: R$ ");

                    string entradaDepositoString = Console.ReadLine();

                    while (entradaDepositoString == "")
                    {
                        Console.Clear();
                        Telas.SegundaTelaDeInicio();
                        Console.WriteLine();
                        Console.Write($"                     {Nome[i]} INFORME O VALOR QUE DESEJA DEPOSITAR: R$ ");
                        entradaDepositoString = Console.ReadLine();
                    }
                    
                    for (int j = 0; j < entradaDepositoString.Length; j++)
                    {

                        while (!char.IsDigit(entradaDepositoString[j]))
                        {
                            j = 0;
                            Console.Clear();
                            Telas.SegundaTelaDeInicio();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("                 INFORME O VALOR DO DEPÓSITO SEM PONTO OU VÍRGULA");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write($"                 {Nome[i]} INFORME O VALOR QUE DESEJA DEPOSITAR: R$ ");
                            entradaDepositoString = Console.ReadLine();
                        }
                    }

                    double entrdaDeposito = double.Parse(entradaDepositoString);

                    Saldo[i] += entrdaDeposito;
                    Console.WriteLine();
                    Console.WriteLine("                     DEPÓSITO EFETUADO COM SUCESSO!!");
                    Console.WriteLine();
                    Console.WriteLine($"                     {Nome[i]}, SEU NOVO SALDO É DE R$ {Saldo[i]:f2}");
                    Console.ReadKey();
                    Console.WriteLine("                     APERTE QUALQUER TECLA PARA CONTINUAR");
                    Console.Clear();
                    Telas.SegundaTelaDeInicio();
                    Console.WriteLine();
                    Telas.SubMenuCliente(CPF, Nome, Senha, Saldo, Conta, CV);

                }

            }
            if (controle == 0)
            {
                Console.WriteLine("                     CPF NÃO LOCALIZADO\n");
                Console.WriteLine("                     PARA SUA SEGURANÇA A SESSÃO ESTÁ SENDO ENCERRADA\n");
                Console.WriteLine("                     AGRADECEMOS A SUA COMPREENÇÃO\n");
                Console.Write("                     APERTE QUALQUER TECLA PARA CONTINUAR");
                Console.ReadKey();
            }

        }
    }
}
