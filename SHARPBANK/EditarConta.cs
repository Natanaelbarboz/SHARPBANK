using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARPBANK
{
    internal class ModificarConta
    {
        public static void EditarConta(List<string> CPF, List<string> Nome, List<string> Senha, List<double> Saldo, List<int> Conta, List<int> CV)
        {
            Console.WriteLine();
            Console.Write("                     INFORME O SEU CPF: ");
            string entradaCPF = Console.ReadLine();

            while (entradaCPF == "")
            {
                Console.Clear();
                Telas.SegundaTelaDeInicio();
                Console.Write("                     INFORME SEU CPF: ");
                entradaCPF = Console.ReadLine();
            }


            for (int i = 0; i < CPF.Count; i++)
            {
                int k = 0;
                if (CPF[i] == entradaCPF)
                {
                    k++;
                    Console.Clear();
                    Telas.SegundaTelaDeInicio();
                    Console.WriteLine();
                    Console.WriteLine($"                     AGÊNCIA: 777  CONTA: {Conta[i]} CV: {CV[i]} \n");
                    Console.WriteLine($"                     CPF: {CPF[i]}\n");
                    Console.WriteLine($"                     NOME: {Nome[i]}\n");
                    Console.WriteLine($"                     SENHA: {Senha[i]}\n");
                    Console.WriteLine();
                    Console.WriteLine("                     1 - EDITAR NOME");
                    Console.WriteLine("                     2 - EDITAR SENHA");
                    Console.WriteLine("                     0 - RETORANAR AO MENU INICIAL");
                    Console.WriteLine();
                    Console.Write("                     DIGITE UMA DAS OOÇÕES ACIMA: ");
                    
                    string entradaEditar = Console.ReadLine();

                    while (entradaEditar != "0" && entradaEditar != "1" && entradaEditar != "2")
                    {
                        Console.WriteLine();
                        Console.WriteLine("                     1 - EDITAR NOME");
                        Console.WriteLine("                     2 - EDITAR SENHA");
                        Console.WriteLine("                     0 - RETORANAR AO MENU INICIAL");
                        Console.WriteLine();
                        Console.Write($"                     {Nome[i]}, OPÇÃO DIGITADA NÃO EXISTE, DIGITE UMA DAS OPÇÕES ACIMA");
                        entradaEditar = Console.ReadLine();

                    }

                    switch (entradaEditar)
                    {
                        case "0":
                            Console.Clear();
                            Telas.SegundaTelaDeInicio();
                            Telas.SubMenuCliente(CPF, Nome, Senha, Saldo, Conta, CV);
                            break;
                        case "1":
                            Console.Write("                     DIGITE O NOME: ");
                            Nome[i] = Console.ReadLine().ToUpper();
                            Console.WriteLine();
                            Console.WriteLine("                     NOME ALTERADO COM SUCESSO!\n");
                            Console.WriteLine($"                     NOVO NOME: {Nome[i]}  \n");
                            Console.WriteLine("                     APERTE QUALQUER TECLA PARA CONTINUAR");
                            Console.ReadKey();
                            Console.Clear();
                            Telas.SegundaTelaDeInicio();
                            Console.WriteLine();
                            Telas.SubMenuCliente(CPF, Nome, Senha, Saldo, Conta, CV);
                            break;
                        case "2":
                            Console.Write("                     DIGITE A NOVA SENHA: ");
                            Senha[i] = Console.ReadLine().ToUpper();
                            Console.WriteLine("                     SENHA ALTERADA COM SUCESSO!\n");
                            Console.WriteLine($"                     NOVA SENHA: {Senha[i]}  \n");
                            Console.WriteLine("                     APERTE QUALQUER TECLA PARA CONTINUAR");
                            Console.ReadKey();
                            Console.Clear();
                            Telas.SegundaTelaDeInicio();
                            Console.WriteLine();
                            Telas.SubMenuCliente(CPF, Nome, Senha, Saldo, Conta, CV);
                            break;
                    }

                }
                if(k == 0)
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
}
