using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SHARPBANK
{
    public class Cliente
    {
        public static void NovoCliente(List<string> CPF, List<string> Nome, List<string> Senha, List<double> Saldo, List<int> Conta, List<int> CV)
        {

            Console.WriteLine("\n\n\n\n                 GENTILEZA PREENCHER OS DADOS ABAIXO PARA ABERTURA DE SUA CONTA\n");
            Console.Write("                 DIGITE O SEU CPF: ");
            string entradaCPF = Console.ReadLine();

            while (entradaCPF.Length < 11 || entradaCPF == "" || entradaCPF.Length > 11)
            {
                Console.Clear();
                Telas.SegundaTelaDeInicio();
                Console.WriteLine("\n\n\n\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                 CPF INVÁLIDO!");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                 GENTILEZA PREENCHER OS DADOS ABAIXO PARA ABERTURA DE SUA CONTA");
                Console.Write("                 DIGITE SEU CPF NOVAMENTE: ");
                entradaCPF = Console.ReadLine();
            }

            for (int i = 0; i < entradaCPF.Length; i++)
            {

                while (!char.IsDigit(entradaCPF[i]))
                {
                    Console.Clear();
                    Telas.SegundaTelaDeInicio();
                    Console.WriteLine("\n\n\n\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("                 CPF INVÁLIDO!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("                 GENTILEZA PREENCHER OS DADOS ABAIXO PARA ABERTURA DE SUA CONTA");
                    Console.Write("                 DIGITE SEU CPF NOVAMENTE: ");
                    entradaCPF = Console.ReadLine();
                }
            }

            Console.Write("\n                 DIGITE SEU NOME: ");
            string entradaNome = Console.ReadLine();
            while (entradaNome == "")
            {
                Console.Clear();
                Telas.SegundaTelaDeInicio();
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("                 GENTILEZA PREENCHER OS DADOS ABAIXO PARA ABERTURA DE SUA CONTA\n");
                Console.WriteLine($"                 CPF: {entradaCPF}\n");
                Console.Write("                 DIGITE SEU NOME: ");
                entradaNome = Console.ReadLine();
            }
            Console.Write("\n                 DIGITE A SENHA QUE DESEJA CADASTRAR: ");
            string entradaSenha = Console.ReadLine();
            while (entradaSenha.Length < 6 || entradaSenha == "")
            {
                Console.Clear();
                Telas.SegundaTelaDeInicio();
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("                 GENTILEZA PREENCHER OS DADOS ABAIXO PARA ABERTURA DE SUA CONTA\n");
                Console.WriteLine($"                 CPF: {entradaCPF}\n");
                Console.WriteLine($"                 NOME: {entradaNome}\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                 SUA SENHA É MUITO CURTA\n");
                Console.WriteLine("                 CADASTRE UMA SENHA COM NO MÍNIMO 6 CARACTERES\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("                 DIGITE A SENHA QUE DESEJA CADASTRAR: ");
                entradaSenha = Console.ReadLine();
            }
            double entradaSaldo = 0;
            int j = 0;
            foreach (string i in CPF)
            {
                if (entradaCPF == i)
                {
                    j++;
                    break;
                }
            }
            if (j == 0)
            {
                
                CPF.Add(entradaCPF);
                Nome.Add(entradaNome.ToUpper());
                Senha.Add(entradaSenha);
                Saldo.Add(entradaSaldo);
                Random conta = new Random();
                int numeroConta = conta.Next(0,99999);
                Random CodV = new Random();
                int codigoDeVerificação = CodV.Next(0,9);

                Conta.Add(numeroConta);
                CV.Add(codigoDeVerificação);

                Console.WriteLine();
                Console.Clear();
                Telas.SegundaTelaDeInicio();
                Console.WriteLine("                     __  _ _   _     __  _   _  _  ___  _    ___  _   _ \r\n                    / _|| | | / \\   / _|/ \\ | \\| ||_ _|/ \\  | __|/ \\ | |\r\n                    \\_ \\| U || o | ( (_( o )| \\\\ | | || o | | _|( o )| |\r\n                    |__/|___||_n_|  \\__|\\_/ |_|\\_| |_||_n_| |_|  \\_/ |_|");
                Console.WriteLine("                      _   ___  ___  ___  ___  _     __  _   _   _   __  _ _   __  ___  __  __   _   || ||\r\n                     / \\ | o )| __|| o \\|_ _|/ \\   / _|/ \\ | \\_/ | / _|| | | / _|| __|/ _|/ _| / \\  L| L|\r\n                    | o || o \\| _| |   / | || o | ( (_( o )| \\_/ | \\_ \\| U |( (_ | _| \\_ \\\\_ \\( o )      \r\n                    |_n_||___/|___||_|\\\\ |_||_n_|  \\__|\\_/ |_| |_| |__/|___| \\__||___||__/|__/ \\_/  () ()\r\n");
                Console.WriteLine("                     VOCÊ JÁ PODE COMEÇAR A UTILIZAR NOSSO SERVIÇOS!!\n\n\n");
                Console.Write("                 PRECIONE UMA TECLA PARA CONTINUAR");
                Console.ReadKey();
                Console.Clear();
                Telas.SegundaTelaDeInicio();
                Telas.SubMenuCliente(CPF, Nome, Senha, Saldo, Conta, CV);
                Console.WriteLine();

            }
            else
            {
                Console.Clear();
                Telas.SegundaTelaDeInicio();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"                 {entradaCPF} CPF JÁ ESTÁ CADASTRADO EM NOSSO SISTEMA.");
                Console.WriteLine("                 ACESSE SUA CONTA COM CPF E SENHA\n\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("                 PRECIONE UMA TECLA PARA CONTINUAR");
                Console.ReadKey();
            }


        }

    }

}
