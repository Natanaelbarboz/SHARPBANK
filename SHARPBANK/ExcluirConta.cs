using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARPBANK
{
    internal class ExcluirConta
    {
        public static void DeletarConta(List<string> CPF, List<string> Nome, List<string> Senha, List<double> Saldo, List<int> Conta, List<int> CV)
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
                    if (Saldo[i] > 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"                     {Nome[i]}, SUA CONTA POSSUÍ O VALOR DE R$ {Saldo[i]:f2}");
                        Console.WriteLine("                     GENTILEZA SACAR O VALOR EM CONTA, CASO CONTRÁRIO PERDERÁ O VALOR");
                    }

                    Console.WriteLine($"\n                     {Nome[i]}, DESEJA REALMENTE ENCERRAR SUA CONTA?");
                    Console.WriteLine("\n                     1 - SIM || 0 - NÃO");
                    Console.Write("\n                     INFORME UMA DAS OPÇÕES: ");
                   
                    string desicao = Console.ReadLine();

                    while (desicao != "1" && desicao != "0")
                    {
                        Console.WriteLine("\n                     1 - SIM || 0 - NÃO");
                        Console.Write($"\n                     {Nome[i].ToUpper()}, OPÇÃO DIGITADA NÃO EXISTE, DIGITE UMA DAS OPÇÕES ACIMA");
                        desicao = Console.ReadLine();

                    }

                    switch (desicao)
                    {
                        case "1":
                            CPF.Remove(CPF[i]);
                            Nome.Remove(Nome[i]);
                            Senha.Remove(Senha[i]);
                            Saldo.Remove(Saldo[i]);
                            Conta.Remove(Conta[i]);
                            CV.Remove(CV[i]);
                            Console.Clear();
                            Console.WriteLine("                      _  __ ___ _  _  __ /\\/  _   ||||\r\n                     / \\_ _| __| \\| |/ _|/ \\ / \\  L|L|\r\n                    | o | || _|| \\\\ ( (_| o ( o )     \r\n                    |_n_|_||___|_|\\_|\\__|_n_|\\_/  ()()\r\n                                                _)              \r\n");
                            Console.WriteLine();
                            Console.WriteLine("                     __ _ _  _     __ _  _  _ ___ _    ___ _  _   _____ ____ _   _ _ //__   _  \r\n                    / _| | |/ \\   / _/ \\| \\| |_ _/ \\  | __/ \\| | | __\\ V / _| | | | | |  \\ / \\ \r\n                    \\_ \\ U | o | ( (( o ) \\\\ || | o | | _( o ) | | _| ) ( (_| |_| U | | o ) o |\r\n                    |__/___|_n_|  \\__\\_/|_|\\_||_|_n_| |_| \\_/|_| |___/_n_\\__|___|___|_|__/|_n_|\r\n");
                            Console.WriteLine("                      __ _  _   _   __ _ _  __ ___ __ __  _   ||||\r\n                     / _/ \\| \\_/ | / _| | |/ _| __/ _/ _|/ \\  L|L|\r\n                    ( (( o ) \\_/ | \\_ \\ U ( (_| _|\\_ \\_ ( o )     \r\n                     \\__\\_/|_| |_| |__/___|\\__|___|__/__/\\_/  ()()\r\n");
                            Console.WriteLine();
                            Console.WriteLine("                      _  ___ ___ _  __   _  __   _    ___  _  ___   ___ ___ ___   __ _ __   _  \r\n                     / \\| o ) o \\ |/ _| / \\|  \\ / \\  | o \\/ \\| o \\ |_ _| __| o \\ / _| |  \\ / \\ \r\n                    ( o ) o \\   / ( |_n| o | o | o ) |  _( o )   /  | || _||   / \\_ \\ | o | o )\r\n                     \\_/|___/_|\\\\_|\\__/|_n_|__/ \\_/  |_|  \\_/|_|\\\\  |_||___|_|\\\\ |__/_|__/ \\_/ \r\n");
                            Console.WriteLine("                     _  _  _  __ __  _     __ _   _ ___ _  _ ___ ___  ||||\r\n                    | \\| |/ \\/ _/ _|/ \\   / _| | | | __| \\| |_ _| __| L|L|\r\n                    | \\\\ ( o )_ \\_ ( o ) ( (_| |_| | _|| \\\\ || || _|      \r\n                    |_|\\_|\\_/|__/__/\\_/   \\__|___|_|___|_|\\_||_||___| ()()");

                            Console.Write("\n                     APERTE QUALQUER TECLA PARA CONTINUAR");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "0":
                            Console.Clear();
                            Telas.SegundaTelaDeInicio();
                            Console.WriteLine();
                            Console.Write("                     APERTE QUALQUER TECLA PARA CONTINUAR");
                            Console.ReadKey();
                            Telas.SubMenuCliente(CPF, Nome, Senha, Saldo, Conta, CV);
                            break;
                    }

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
