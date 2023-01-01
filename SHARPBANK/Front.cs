using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARPBANK
{

    internal class Front
    {
        public static void TelaDenicio()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                .______    _______ .___  ___. ____    ____  __  .__   __.  _______   ______      __   __  \r\n                |   _  \\  |   ____||   \\/   | \\   \\  /   / |  | |  \\ |  | |       \\ /  __  \\    |  | |  | \r\n                |  |_)  | |  |__   |  \\  /  |  \\   \\/   /  |  | |   \\|  | |  .--.  |  |  |  |   |  | |  | \r\n                |   _  <  |   __|  |  |\\/|  |   \\      /   |  | |  . `  | |  |  |  |  |  |  |   |  | |  | \r\n                |  |_)  | |  |____ |  |  |  |    \\    /    |  | |  |\\   | |  '--'  |  `--'  |   |__| |__| \r\n                |______/  |_______||__|  |__|     \\__/     |__| |__| \\__| |_______/ \\______/    (__) (__) \r\n                                                                                          \r\n                                                 ___       ______   \r\n                                                /   \\     /  __  \\  \r\n                                               /  ^  \\   |  |  |  | \r\n                                              /  /_\\  \\  |  |  |  | \r\n                                             /  _____  \\ |  `--'  | \r\n                                            /__/     \\__\\ \\______/  \r\n                            \r\n             _______. __    __       ___      .______      .______   .______        ___      .__   __.  __  ___ \r\n            /       ||  |  |  |     /   \\     |   _  \\     |   _  \\  |   _  \\      /   \\     |  \\ |  | |  |/  / \r\n           |   (----`|  |__|  |    /  ^  \\    |  |_)  |    |  |_)  | |  |_)  |    /  ^  \\    |   \\|  | |  '  /  \r\n            \\   \\    |   __   |   /  /_\\  \\   |      /     |   ___/  |   _  <    /  /_\\  \\   |  . `  | |    <   \r\n        .----)   |   |  |  |  |  /  _____  \\  |  |\\  \\----.|  |      |  |_)  |  /  _____  \\  |  |\\   | |  .  \\  \r\n        |_______/    |__|  |__| /__/     \\__\\ | _| `._____|| _|      |______/  /__/     \\__\\ |__| \\__| |__|\\__\\ \r\n\n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void SegundaTelaDeInicio()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                        \r\n                 ____    __  __  ______  ____    ____    ____     ______  __  __  __  __     \r\n                /\\  _`\\ /\\ \\/\\ \\/\\  _  \\/\\  _`\\ /\\  _`\\ /\\  _`\\  /\\  _  \\/\\ \\/\\ \\/\\ \\/\\ \\    \r\n                \\ \\,\\L\\_\\ \\ \\_\\ \\ \\ \\L\\ \\ \\ \\L\\ \\ \\ \\L\\ \\ \\ \\L\\ \\\\ \\ \\L\\ \\ \\ `\\\\ \\ \\ \\/'/'   \r\n                 \\/_\\__ \\\\ \\  _  \\ \\  __ \\ \\ ,  /\\ \\ ,__/\\ \\  _ <'\\ \\  __ \\ \\ , ` \\ \\ , <    \r\n                   /\\ \\L\\ \\ \\ \\ \\ \\ \\ \\/\\ \\ \\ \\\\ \\\\ \\ \\/  \\ \\ \\L\\ \\\\ \\ \\/\\ \\ \\ \\`\\ \\ \\ \\\\`\\  \r\n                   \\ `\\____\\ \\_\\ \\_\\ \\_\\ \\_\\ \\_\\ \\_\\ \\_\\   \\ \\____/ \\ \\_\\ \\_\\ \\_\\ \\_\\ \\_\\ \\_\\\r\n                    \\/_____/\\/_/\\/_/\\/_/\\/_/\\/_/\\/ /\\/_/    \\/___/   \\/_/\\/_/\\/_/\\/_/\\/_/\\/_/\r\n");
            Console.WriteLine("                     AQUI O SEU DINHEIRO RENDE MAIS!!\n");
            //Console.ForegroundColor = ConsoleColor.White;
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

        public static void SubMenuCliente(List<string> CPF, List<string> Nome, List<string> Senha, List<double> Saldo)
        {
            
            Console.WriteLine("\n                     1 - SAQUE");
            Console.WriteLine("                     2 - DEPÓSITO");
            Console.WriteLine("                     3 - EDITAR CONTA");
            Console.WriteLine("                     4 - DETALHE CONTA");
            Console.WriteLine("                     5 - DELETAR CONTA");
            Console.WriteLine("                     0 - SAIR\n");
            Console.Write("                     SELECIONE UMA DAS OPÇÕES ACIMA: ");

            string entradaDadosString = Console.ReadLine();

            while (entradaDadosString == "")
            {
                Console.Clear();
                Front.SegundaTelaDeInicio();
                Console.WriteLine("\n                     1 - SAQUE");
                Console.WriteLine("                     2 - DEPÓSITO");
                Console.WriteLine("                     3 - EDITAR CONTA");
                Console.WriteLine("                     4 - DETALHE CONTA");
                Console.WriteLine("                     5 - DELETAR CONTA");
                Console.WriteLine("                     0 - SAIR\n");
                Console.Write("                     SELECIONE UMA DAS OPÇÕES ACIMA: ");
                entradaDadosString = Console.ReadLine();
            }

            int entradaDados = int.Parse(entradaDadosString);
            
           
            while (entradaDados !=0 && entradaDados != 1 && entradaDados != 2 && entradaDados != 3 && entradaDados != 4 && entradaDados != 5)
            {
                Console.Clear();
                Front.SegundaTelaDeInicio();
                Console.WriteLine();
                Console.WriteLine("                     1 - SAQUE");
                Console.WriteLine("                     2 - DEPÓSITO");
                Console.WriteLine("                     3 - EDITAR CONTA");
                Console.WriteLine("                     4 - DETALHE CONTA");
                Console.WriteLine("                     5 - DELETAR CONTA");
                Console.WriteLine("                     0 - SAIR\n");
                Console.Write("                     SELECIONE UMA DAS OPÇÕES ACIMA: ");
                entradaDados = int.Parse(Console.ReadLine());

            }

            switch (entradaDados)
            {
                case 0:
                    Console.Clear();
                    MenuCliente();
                    break;
                case 1:
                    Console.Clear();
                    SegundaTelaDeInicio();
                    Sacar.Saque(CPF, Nome, Senha, Saldo);
                    break;
                case 2:
                    Console.Clear();
                    SegundaTelaDeInicio();
                    Depositar.Deposito(CPF, Nome, Senha, Saldo);
                    break;
                case 3:
                    Console.Clear();
                    SegundaTelaDeInicio();
                    ModificarConta.EditarConta(CPF, Nome, Senha, Saldo);
                    break;
                case 4:
                    Console.Clear();
                    SegundaTelaDeInicio();
                    DetalheDaConta.DetalhedaContaCliente(CPF, Nome, Senha, Saldo);
                    break;
                case 5:
                    Console.Clear();
                    SegundaTelaDeInicio();
                    ExcluirConta.DeletarConta(CPF, Nome, Senha, Saldo);
                    break;
            }
        }


    }
}
