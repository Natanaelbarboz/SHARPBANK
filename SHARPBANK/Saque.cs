using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARPBANK
{
    internal class Sacar
    {
        public static void Saque(List<string> CPF, List<string> Nome, List<string> Senha, List<double> Saldo, List<int> Conta, List<int> CV)
        {

            Console.Write("\n                     INFORME SEU CPF: ");
            string entradaCPF = Console.ReadLine();
            while (entradaCPF == "")
            {
                Console.Clear();
                Telas.SegundaTelaDeInicio();
                Console.Write("\n                     INFORME SEU CPF: ");
                entradaCPF = Console.ReadLine();
            }

            int j = 0;

            for (int i = 0; i < CPF.Count; i++)
            {

                if (entradaCPF == CPF[i])
                {
                    j++;
                    Console.Write($"\n                     {Nome[i]} INFORME O VALOR QUE DESEJA SACAR: R$ ");
                    string entradaSaqueString = Console.ReadLine();
                    while (entradaSaqueString =="" )
                    {
                        Console.Clear();
                        Telas.SegundaTelaDeInicio();
                        Console.Write($"\n                     {Nome[i]} INFORME O VALOR QUE DESEJA SACAR: R$ ");
                        entradaSaqueString = Console.ReadLine();
                    }

                    for (int k = 0; k < entradaSaqueString.Length; k++)
                    {

                        while (!char.IsDigit(entradaSaqueString[k]))
                        {
                            k = 0;
                            Console.Clear();
                            Telas.SegundaTelaDeInicio();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("                 INFORME O VALOR QUE DESEJA SACAR SEM PONTO OU VÍRGULA");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write($"                 {Nome[i]} INFORME O VALOR QUE DESEJA SACAR: R$ ");
                            entradaSaqueString = Console.ReadLine();
                        }
                    }

                    double entrdaSaque = double.Parse(entradaSaqueString);


                    if (Saldo[i] < entrdaSaque)
                    {

                        Console.Clear();
                        Telas.SegundaTelaDeInicio();
                        Console.WriteLine($"                     {Nome[i]}, NÃO FOI POSSÍVEL REALIZAR O SEU SAQUE.");
                        Console.WriteLine($"                     SALDO INSUFICIÊNTE, SEU SALDO ATUAL É DE R$ {Saldo[i]:f2}\n");
                        Console.WriteLine("\n                     TECLE UMA TECLA PARA CONTINUAR: ");
                        Console.ReadKey();
                        Console.Clear();
                        Telas.SegundaTelaDeInicio();
                        Telas.SubMenuCliente(CPF, Nome, Senha, Saldo, Conta, CV);
                    }
                    else
                    {
                        Console.Clear();
                        Telas.SegundaTelaDeInicio();
                        Saldo[i] -= entrdaSaque;
                        Console.WriteLine("                     SAQUE EFETUADO COM SUCESSO!");
                        Console.WriteLine($"                     {Nome[i]}, SEU SALDO AGORA É DE R$ {Saldo[i]:f2}");
                        Console.WriteLine("\n                     TECLE UMA TECLA PARA CONTINUAR: ");
                        Console.ReadKey();
                        Console.Clear();
                        Telas.SegundaTelaDeInicio();
                        Telas.SubMenuCliente(CPF, Nome, Senha, Saldo, Conta, CV);
                    }

                }

            }

            if (j == 0)
            {
                Console.WriteLine("                     CPF NÃO LOCALIZADO\n");
                Console.WriteLine("                     PARA SUA SEGURANÇA A SESSÃO ESTÁ SENDO ENCERRADA\n");
                Console.WriteLine("                     AGRADECEMOS A SUA COMPREENÇÃO\n");
                Console.WriteLine("                     APERTE QUALQUER TECLA PARA CONTINUAR");
                Console.ReadKey();
            }

        }

    }
}
