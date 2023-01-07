﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARPBANK
{
    internal class EntrarNaConta
    {
        public static void AcessarConta(List<string> CPF, List<string> Nome, List<string> Senha, List<double> Saldo, List<int> Conta, List<int> CV)
        {            
            Console.WriteLine();
            Console.Write("                     INFORME O SEU CPF: ");
            string entradaCPF = Console.ReadLine();
            while (entradaCPF =="")
            {
                Console.Clear();
                Telas.SegundaTelaDeInicio();
                Console.Write("                     INFORME O SEU CPF: ");
                entradaCPF = Console.ReadLine();
            }

            Console.Write("\n                     INFORME A SUA SENHA: ");
            string entradaSenha = Console.ReadLine();
            while (entradaSenha == "")
            {
                Console.Clear();
                Telas.SegundaTelaDeInicio();
                Console.WriteLine(entradaCPF);
                Console.WriteLine();
                Console.Write("                     INFORME A SUA SENHA: ");
                entradaSenha = Console.ReadLine();
            }

            int j = 0;

            for (int i = 0; i < CPF.Count; i++)
            {

                if (CPF[i] == entradaCPF)
                {
                   
                    if (entradaSenha == Senha[i])
                    {
                         j++;

                        Console.WriteLine($"                     AGÊNCIA: 777  CONTA: {Conta[i]} CV: {CV[i]} \n");
                        Console.WriteLine($"                     CPF: {CPF[i]}\n");
                        Console.WriteLine($"                     NOME: {Nome[i]} \n");
                        Console.WriteLine($"                     SENHA: {Senha[i]} \n");
                        Console.WriteLine($"                     SALDO: R$ {Saldo[i]:f2} \n");

                        Console.Write("                     APERTE QUALQUER TECLA PARA CONTINUAR");
                        Console.ReadKey();
                        Console.Clear();
                        Telas.SegundaTelaDeInicio();
                        Console.WriteLine();
                        Telas.SubMenuCliente(CPF, Nome, Senha, Saldo, Conta, CV);                        

                    }
                   
                }

            }
            if (j == 0)
            {
                Console.WriteLine("                     USUÁRIO OU SENHA INCORRETO\n");
                Console.WriteLine("                     PARA SUA SEGURANÇA A SESSÃO ESTÁ SENDO ENCERRADA\n");
                Console.WriteLine("                     AGRADECEMOS A SUA COMPREENÇÃO\n");
                Console.Write("                     APERTE QUALQUER TECLA PARA CONTINUAR");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}