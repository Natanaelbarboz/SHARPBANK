using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARPBANK
{

    internal class Telas
    {

        public static void TelaDenicio()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                     ____     ____             __  __  ______  __  __  ____    _____      \r\n                    /\\  _`\\  /\\  _`\\   /'\\_/`\\/\\ \\/\\ \\/\\__  _\\/\\ \\/\\ \\/\\  _`\\ /\\  __`\\    \r\n                    \\ \\ \\L\\ \\\\ \\ \\L\\_\\/\\      \\ \\ \\ \\ \\/_/\\ \\/\\ \\ `\\\\ \\ \\ \\/\\ \\ \\ \\/\\ \\   \r\n                     \\ \\  _ <'\\ \\  _\\L\\ \\ \\__\\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ , ` \\ \\ \\ \\ \\ \\ \\ \\ \\  \r\n                      \\ \\ \\L\\ \\\\ \\ \\L\\ \\ \\ \\_/\\ \\ \\ \\_/ \\ \\_\\ \\_\\ \\ \\`\\ \\ \\ \\_\\ \\ \\ \\_\\ \\ \r\n                       \\ \\____/ \\ \\____/\\ \\_\\\\ \\_\\ `\\___/ /\\_____\\ \\_\\ \\_\\ \\____/\\ \\_____\\\r\n                        \\/___/   \\/___/  \\/_/ \\/_/`\\/__/  \\/_____/\\/_/\\/_/\\/___/  \\/_____/                                                                      \r\n                                                 ______  _____      \r\n                                                /\\  _  \\/\\  __`\\    \r\n                                                \\ \\ \\L\\ \\ \\ \\/\\ \\   \r\n                                                 \\ \\  __ \\ \\ \\ \\ \\  \r\n                                                  \\ \\ \\/\\ \\ \\ \\_\\ \\ \r\n                                                   \\ \\_\\ \\_\\ \\_____\\\r\n                                                    \\/_/\\/_/\\/_____/                    \r\n\r\n                     ____    __  __  ______  ____    ____    ____     ______  __  __  __  __     \r\n                    /\\  _`\\ /\\ \\/\\ \\/\\  _  \\/\\  _`\\ /\\  _`\\ /\\  _`\\  /\\  _  \\/\\ \\/\\ \\/\\ \\/\\ \\    \r\n                    \\ \\,\\L\\_\\ \\ \\_\\ \\ \\ \\L\\ \\ \\ \\L\\ \\ \\ \\L\\ \\ \\ \\L\\ \\\\ \\ \\L\\ \\ \\ `\\\\ \\ \\ \\/'/'   \r\n                     \\/_\\__ \\\\ \\  _  \\ \\  __ \\ \\ ,  /\\ \\ ,__/\\ \\  _ <'\\ \\  __ \\ \\ , ` \\ \\ , <    \r\n                       /\\ \\L\\ \\ \\ \\ \\ \\ \\ \\/\\ \\ \\ \\\\ \\\\ \\ \\/  \\ \\ \\L\\ \\\\ \\ \\/\\ \\ \\ \\`\\ \\ \\ \\\\`\\  \r\n                       \\ `\\____\\ \\_\\ \\_\\ \\_\\ \\_\\ \\_\\ \\_\\ \\_\\   \\ \\____/ \\ \\_\\ \\_\\ \\_\\ \\_\\ \\_\\ \\_\\\r\n                        \\/_____/\\/_/\\/_/\\/_/\\/_/\\/_/\\/ /\\/_/    \\/___/   \\/_/\\/_/\\/_/\\/_/\\/_/\\/_/\r\n");
        }

        public static void SegundaTelaDeInicio()
        {
            Console.WriteLine("                        \r\n                 ____    __  __  ______  ____    ____    ____     ______  __  __  __  __     \r\n                /\\  _`\\ /\\ \\/\\ \\/\\  _  \\/\\  _`\\ /\\  _`\\ /\\  _`\\  /\\  _  \\/\\ \\/\\ \\/\\ \\/\\ \\    \r\n                \\ \\,\\L\\_\\ \\ \\_\\ \\ \\ \\L\\ \\ \\ \\L\\ \\ \\ \\L\\ \\ \\ \\L\\ \\\\ \\ \\L\\ \\ \\ `\\\\ \\ \\ \\/'/'   \r\n                 \\/_\\__ \\\\ \\  _  \\ \\  __ \\ \\ ,  /\\ \\ ,__/\\ \\  _ <'\\ \\  __ \\ \\ , ` \\ \\ , <    \r\n                   /\\ \\L\\ \\ \\ \\ \\ \\ \\ \\/\\ \\ \\ \\\\ \\\\ \\ \\/  \\ \\ \\L\\ \\\\ \\ \\/\\ \\ \\ \\`\\ \\ \\ \\\\`\\  \r\n                   \\ `\\____\\ \\_\\ \\_\\ \\_\\ \\_\\ \\_\\ \\_\\ \\_\\   \\ \\____/ \\ \\_\\ \\_\\ \\_\\ \\_\\ \\_\\ \\_\\\r\n                    \\/_____/\\/_/\\/_/\\/_/\\/_/\\/_/\\/ /\\/_/    \\/___/   \\/_/\\/_/\\/_/\\/_/\\/_/\\/_/\r\n");
            Console.WriteLine("                     AQUI O SEU DINHEIRO RENDE MAIS!!\n");
        }

        public static void MenuInicial()
        {
            TelaDenicio();
            Console.WriteLine("                                             1 - ÁREA DO CLIENTE");
            Console.WriteLine("                                             2 - ÁREA DO COLABORADOR");
            Console.WriteLine("                                             0 - SAIR DO PROGRAMA\n");
            Console.Write("                                             DIGITE A OPÇÃO DESEJADA: ");
        }

        public static void MenuCliente()
        {
           
            Console.WriteLine();
            Console.WriteLine("                                         1 - CRIAR CONTA");
            Console.WriteLine("                                         2 - ACESSAR CONTA");
            Console.WriteLine("                                         0 - RETONAR AO MENU ANTERIOR\n");
            Console.Write("                                         DIGITE A OPÇÃO DESEJADA: ");

        }

        public static void SubMenuCliente(List<string> CPF, List<string> Nome, List<string> Senha, List<double> Saldo, List<int> Conta, List<int> CV)
        {


            Console.WriteLine("\n                     1 - SAQUE");
            Console.WriteLine("                     2 - DEPÓSITO");
            Console.WriteLine("                     3 - TRANSFERÊNCIA");
            Console.WriteLine("                     4 - EDITAR CONTA");
            Console.WriteLine("                     5 - DETALHE CONTA");
            Console.WriteLine("                     6 - DELETAR CONTA");
            Console.WriteLine("                     0 - SAIR\n");
            Console.Write("                     SELECIONE UMA DAS OPÇÕES ACIMA: ");

            string entradaDados = Console.ReadLine();
            
           
            while (entradaDados !="0" && entradaDados != "1" && entradaDados != "2" && entradaDados != "3" && entradaDados != "4" && entradaDados != "5" && entradaDados != "6")
            {
                Console.Clear();
                Telas.SegundaTelaDeInicio();
                Console.WriteLine("\n                     1 - SAQUE");
                Console.WriteLine("                     2 - DEPÓSITO");
                Console.WriteLine("                     3 - TRANSFERÊNCIA");
                Console.WriteLine("                     4 - EDITAR CONTA");
                Console.WriteLine("                     5 - DETALHE CONTA");
                Console.WriteLine("                     6 - DELETAR CONTA");
                Console.WriteLine("                     0 - SAIR\n");
                Console.Write("                     SELECIONE UMA DAS OPÇÕES ACIMA: ");
                entradaDados = Console.ReadLine();

            }

            switch (entradaDados)
            {
                case "0":
                    Console.Clear();
                    MenuCliente();
                    break;
                case "1":
                    Console.Clear();
                    SegundaTelaDeInicio();
                    Sacar.Saque(CPF, Nome, Senha, Saldo, Conta, CV);
                    break;
                case "2":
                    Console.Clear();
                    SegundaTelaDeInicio();
                    Depositar.Deposito(CPF, Nome, Senha, Saldo, Conta, CV);
                    break;
                case "3":
                    Console.Clear();
                    SegundaTelaDeInicio();
                    Transferencia.Pix(CPF, Nome, Senha, Saldo, Conta, CV);
                    break;
                case "4":
                    Console.Clear();
                    SegundaTelaDeInicio();
                    ModificarConta.EditarConta(CPF, Nome, Senha, Saldo, Conta, CV);
                    break;
                case "5":
                    Console.Clear();
                    SegundaTelaDeInicio();
                    DetalheDaConta.DetalhedaContaCliente(CPF, Nome, Senha, Saldo, Conta, CV);
                    break;
                    case "6":
                    Console.Clear();
                    SegundaTelaDeInicio();
                    ExcluirConta.DeletarConta(CPF, Nome, Senha, Saldo, Conta, CV);
                    break;
            }
        }


    }
}
