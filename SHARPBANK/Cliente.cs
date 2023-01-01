using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SHARPBANK
{
   public class Cliente
    {       
        public static void NovoCliente(List<string> CPF, List<string> Nome, List<string> Senha, List<double> Saldo)
        {

            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("                 GENTILEZA PREENCHER OS DADOS ABAIXO PARA ABERTURA DE SUA CONTA");
            Console.WriteLine();
            Console.Write("                 DIGITE O SEU CPF: ");
            string entradaCPF = Console.ReadLine();

            while (entradaCPF.Length < 11 || entradaCPF == "" || entradaCPF.Length > 11)
            {
                Console.Clear();
                Front.SegundaTelaDeInicio();
                Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                 GENTILEZA PREENCHER OS DADOS ABAIXO PARA ABERTURA DE SUA CONTA");
                Console.WriteLine("                 CPF INVÁLIDO!");
                Console.Write("                 DIGITE SEU CPF NOVAMENTE: ");
                entradaCPF = Console.ReadLine();
            }


            if (entradaCPF.Length == 11)
            {
                for (int i = 0; i < entradaCPF.Length; i++)
                {

                    while (!char.IsDigit(entradaCPF[i]))
                    {
                        Console.Clear();
                        Front.SegundaTelaDeInicio();                      
                        Console.WriteLine("\n\n\n\n");
                        Console.WriteLine("                 GENTILEZA PREENCHER OS DADOS ABAIXO PARA ABERTURA DE SUA CONTA");
                        Console.WriteLine("                 CPF INVÁLIDO");
                        Console.Write("                 DIGITE SEU CPF NOVAMENTE: ");
                        entradaCPF = Console.ReadLine();
                    }
                }
            }
            Console.WriteLine();

            Console.Write("                 DIGITE SEU NOME: ");
            string entradaNome = Console.ReadLine();
            while (entradaNome == "")
            {
                Console.Clear();
                Front.SegundaTelaDeInicio();
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("                 GENTILEZA PREENCHER OS DADOS ABAIXO PARA ABERTURA DE SUA CONTA");
                Console.WriteLine($"                 CPF: {entradaCPF}");
                Console.WriteLine();
                Console.Write("                 DIGITE SEU NOME: ");
                entradaNome = Console.ReadLine();
            }
            Console.WriteLine();
            Console.Write("                 DIGITE A SENHA QUE DESEJA CADASTRAR: ");
            string entradaSenha = Console.ReadLine();
            while (entradaSenha.Length < 6 || entradaSenha == "")
            {
                Console.WriteLine("                 SUA SENHA É MUITO CURTA\n");
                Console.WriteLine("                 CADASTRE UMA SENHA COM NO MÍNIMO 6 CARACTERES\n");
                Console.WriteLine();
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

                Nome.Add(entradaNome);
                Senha.Add(entradaSenha);
                Saldo.Add(entradaSaldo);
                Console.WriteLine();
                Console.Clear();
                Front.SegundaTelaDeInicio();
                Console.WriteLine("                     __  _ _   _     __  _   _  _  ___  _    ___  _   _ \r\n                    / _|| | | / \\   / _|/ \\ | \\| ||_ _|/ \\  | __|/ \\ | |\r\n                    \\_ \\| U || o | ( (_( o )| \\\\ | | || o | | _|( o )| |\r\n                    |__/|___||_n_|  \\__|\\_/ |_|\\_| |_||_n_| |_|  \\_/ |_|");
                Console.WriteLine("                      _   ___  ___  ___  ___  _     __  _   _   _   __  _ _   __  ___  __  __   _   || ||\r\n                     / \\ | o )| __|| o \\|_ _|/ \\   / _|/ \\ | \\_/ | / _|| | | / _|| __|/ _|/ _| / \\  L| L|\r\n                    | o || o \\| _| |   / | || o | ( (_( o )| \\_/ | \\_ \\| U |( (_ | _| \\_ \\\\_ \\( o )      \r\n                    |_n_||___/|___||_|\\\\ |_||_n_|  \\__|\\_/ |_| |_| |__/|___| \\__||___||__/|__/ \\_/  () ()\r\n");
                Console.WriteLine("                     VOCÊ JÁ PODE COMEÇAR A UTILIZAR NOSSO SERVIÇOS!!\n");

                Front.SubMenuCliente(CPF, Nome, Senha, Saldo);
                Console.WriteLine();

            }
            else
            {
                Console.Clear();
                Front.SegundaTelaDeInicio();
                Console.WriteLine($"                 {entradaCPF} CPF JÁ ESTÁ CADASTRADO EM NOSSO SISTEMA.");
                Console.WriteLine("                 ACESSE SUA CONTA COM CPF E SENHA\n\n");
                Console.Write("                 PRECISO UMA TECLA PARA CONTINUAR");
                Console.ReadKey();
            }

            

        }        

    }

}
