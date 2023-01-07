using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARPBANK
{
    public class Transferencia
    {
        public static void Pix(List<string> CPF, List<string> Nome, List<string> Senha, List<double> Saldo, List<int> Conta, List<int> CV)
        {
            Console.WriteLine();
            Console.Write("                     INFORME SEU CPF: ");
            string entradaCPF = Console.ReadLine();
            while (entradaCPF == "" || entradaCPF.Length < 11 || entradaCPF.Length > 11)
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
                    Console.Write("                     INFORME O CPF DO BENEFICIÁRIO: ");
                    string entradaCPFTranferencia = Console.ReadLine();
                    while (entradaCPFTranferencia == "" || entradaCPFTranferencia.Length < 11 || entradaCPFTranferencia.Length > 11)
                    {
                        Console.Clear();
                        Telas.SegundaTelaDeInicio();
                        Console.Write("                     INFORME O CPF DO BENEFICIÁRIO: ");
                        entradaCPFTranferencia = Console.ReadLine();
                    }

                    for (int j = 0; j < CPF.Count; j++)
                    {

                        if (entradaCPFTranferencia == CPF[j])
                        {

                            Console.Write($"\n                     {Nome[i]} INFORME O VALOR QUE DESEJA TRANSFERIR: R$ ");
                            string entradaTranferencia = Console.ReadLine();
                            
                            for (int k = 0; k < entradaTranferencia.Length; k++)
                            {
                                while (!char.IsDigit(entradaTranferencia[k]))
                                {
                                    k = 0;
                                    Console.Clear();
                                    Telas.SegundaTelaDeInicio();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("                 INFORME O VALOR QUE DESEJA TRANSFERIR SEM PONTO OU VÍRGULA");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write($"                 {Nome[i]} INFORME O VALOR QUE DESEJA TRANSFERIR: R$ ");
                                    entradaTranferencia = Console.ReadLine();
                                }
                            }

                            Double entradaTranferenciaDouble = double.Parse(entradaTranferencia);

                            if (entradaTranferenciaDouble <= Saldo[i])
                            {
                                Saldo[i] -= entradaTranferenciaDouble;
                                Saldo[j] += entradaTranferenciaDouble;

                                Console.WriteLine($"                     {Nome[i]}, O VALOR DE R$ {entradaTranferenciaDouble:F2} FOI TRANSFERIDO COM SUCESSO\n");
                                Console.WriteLine($"                     {Nome[i]}, O SEU NOVO SALDO É DE R$ {Saldo[i]:f2}\n");
                                Console.ReadKey();
                                Console.WriteLine("                     APERTE QUALQUER TECLA PARA CONTINUAR");
                                Console.Clear();
                                Telas.SegundaTelaDeInicio();
                                Console.WriteLine();
                                Telas.SubMenuCliente(CPF, Nome, Senha, Saldo, Conta, CV);

                            }
                            else
                            {
                                Console.WriteLine($"                     {Nome[i]}, NÃO FOI POSSÍVEL REALIZAR A TRANSFERENCIA NO VALOR DE R$ {entradaTranferenciaDouble:F2}\n");
                                Console.WriteLine($"                     SEU SALDO É INSUFICIENTE. SALDO ATUAL R$ {Saldo[i]}\n");
                                Console.ReadKey();
                                Console.WriteLine("                     APERTE QUALQUER TECLA PARA CONTINUAR");
                                Console.Clear();
                                Telas.SegundaTelaDeInicio();
                                Console.WriteLine();
                                Telas.SubMenuCliente(CPF, Nome, Senha, Saldo, Conta, CV);
                            }

                        }


                    }


                }

            }
            if (controle == 0)
            {
                Console.WriteLine($"                     {entradaCPF} NÃO LOCALIZADO EM NOSSA BASE\n");
                Console.WriteLine("                     PARA SUA SEGURANÇA A SESSÃO ESTÁ SENDO ENCERRADA\n");
                Console.WriteLine("                     AGRADECEMOS A SUA COMPREENÇÃO\n");
                Console.Write("                     APERTE QUALQUER TECLA PARA CONTINUAR");
                Console.ReadKey();
            }

        }


    }
}
