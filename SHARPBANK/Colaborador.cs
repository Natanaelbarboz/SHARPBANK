using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARPBANK
{
    public class Colaborador
    {
        public static void InicioBack(List<string> CPF, List<string> Nome, List<string> Senha, List<double> Saldo, List<int> Conta, List<int> CV)
        {
            Console.Clear();
            Console.WriteLine("        \r\n                      _ ___ ___ _  _  __ /\\/  _   ||||\r\n                     / \\_ _| __| \\| |/ _|/ \\ / \\  L|L|\r\n                    | o | || _|| \\\\ ( (_| o ( o )     \r\n                    |_n_|_||___|_|\\_|\\__|_n_|\\_/  ()()\r\n                                      _)              \r\n\r\n                     ___ __ __  _    //  ___ ___  _    //_ \r\n                    | __/ _/ _|/ \\   / \\| o \\ __|/ \\  | __|\r\n                    | _|\\_ \\_ \\ o | | o |   / _|| o | | _| \r\n                    |___|__/__/_n_| |_n_|_|\\\\___|_n_| |___|\r\n                                       \r\n                      _  ___ ___ _  _  _  __   ___  _  ___  _     __ _  _    _  ___  _  ___  _  __   _  ___ ___ __ \r\n                     / \\| o \\ __| \\| |/ \\/ _| | o \\/ \\| o \\/ \\   / _/ \\| |  / \\| o )/ \\| o \\/ \\|  \\ / \\| o \\ __/ _|\r\n                    | o |  _/ _|| \\\\ | o \\_ \\ |  _/ o |   / o | ( (( o ) |_| o | o ( o )   / o | o | o )   / _|\\_ \\\r\n                    |_n_|_| |___|_|\\_|_n_|__/ |_| |_n_|_|\\\\_n_|  \\__\\_/|___|_n_|___/\\_/|_|\\\\_n_|__/ \\_/|_|\\\\___|__/\r\n\n");
            Console.Write("                     PRECIONE QUALQUER TECLA PARA CONTINUAR: ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("        \r\n                      _ ___ ___ _  _  __ /\\/  _   ||||\r\n                     / \\_ _| __| \\| |/ _|/ \\ / \\  L|L|\r\n                    | o | || _|| \\\\ ( (_| o ( o )     \r\n                    |_n_|_||___|_|\\_|\\__|_n_|\\_/  ()()\r\n                                      _)              \r\n\r\n                     ___ __ __  _    //  ___ ___  _    //_ \r\n                    | __/ _/ _|/ \\   / \\| o \\ __|/ \\  | __|\r\n                    | _|\\_ \\_ \\ o | | o |   / _|| o | | _| \r\n                    |___|__/__/_n_| |_n_|_|\\\\___|_n_| |___|\r\n                                       \r\n                      _  ___ ___ _  _  _  __   ___  _  ___  _     __ _  _    _  ___  _  ___  _  __   _  ___ ___ __ \r\n                     / \\| o \\ __| \\| |/ \\/ _| | o \\/ \\| o \\/ \\   / _/ \\| |  / \\| o )/ \\| o \\/ \\|  \\ / \\| o \\ __/ _|\r\n                    | o |  _/ _|| \\\\ | o \\_ \\ |  _/ o |   / o | ( (( o ) |_| o | o ( o )   / o | o | o )   / _|\\_ \\\r\n                    |_n_|_| |___|_|\\_|_n_|__/ |_| |_n_|_|\\\\_n_|  \\__\\_/|___|_n_|___/\\_/|_|\\\\_n_|__/ \\_/|_|\\\\___|__/\r\n");
            Console.WriteLine("                     DESEJA REALMENTE CONTINUAR?\n");
            Console.Write("                     1 - SIM || 0 - NÃO: ");

            string saidaInicioBackString = Console.ReadLine();

            while (saidaInicioBackString != "0" && saidaInicioBackString != "1")
            {
                Console.Clear();
                Console.WriteLine("        \r\n                      _ ___ ___ _  _  __ /\\/  _   ||||\r\n                     / \\_ _| __| \\| |/ _|/ \\ / \\  L|L|\r\n                    | o | || _|| \\\\ ( (_| o ( o )     \r\n                    |_n_|_||___|_|\\_|\\__|_n_|\\_/  ()()\r\n                                      _)              \r\n\r\n                     ___ __ __  _    //  ___ ___  _    //_ \r\n                    | __/ _/ _|/ \\   / \\| o \\ __|/ \\  | __|\r\n                    | _|\\_ \\_ \\ o | | o |   / _|| o | | _| \r\n                    |___|__/__/_n_| |_n_|_|\\\\___|_n_| |___|\r\n                                       \r\n                      _  ___ ___ _  _  _  __   ___  _  ___  _     __ _  _    _  ___  _  ___  _  __   _  ___ ___ __ \r\n                     / \\| o \\ __| \\| |/ \\/ _| | o \\/ \\| o \\/ \\   / _/ \\| |  / \\| o )/ \\| o \\/ \\|  \\ / \\| o \\ __/ _|\r\n                    | o |  _/ _|| \\\\ | o \\_ \\ |  _/ o |   / o | ( (( o ) |_| o | o ( o )   / o | o | o )   / _|\\_ \\\r\n                    |_n_|_| |___|_|\\_|_n_|__/ |_| |_n_|_|\\\\_n_|  \\__\\_/|___|_n_|___/\\_/|_|\\\\_n_|__/ \\_/|_|\\\\___|__/\r\n");
                Console.WriteLine("                     DESEJA REALMENTE CONTINUAR?\n");
                Console.Write("                     1 - SIM || 0 - NÃO: ");
                saidaInicioBackString = Console.ReadLine();
            }
            switch (saidaInicioBackString)
            {
                case "0":
                    Console.Clear();
                    Telas.MenuInicial();
                    break;
                case "1":
                    Console.Clear();
                    MenuBack(CPF, Nome, Senha, Saldo, Conta, CV);
                    break;
            }
        }

        public static void MenuBack(List<string> CPF, List<string> Nome, List<string> Senha, List<double> Saldo, List<int> Conta, List<int> CV)
        {
            Console.WriteLine("                 ___ ___ _   _   _ _ _ _  _ __   _     __ _  _    _  ___  _  ___  _  __   _  ___  ||||||\r\n                | o ) __| \\_/ | | | | | \\| |  \\ / \\   / _/ \\| |  / \\| o )/ \\| o \\/ \\|  \\ / \\| o \\ L|L|L|\r\n                | o \\ _|| \\_/ | | V | | \\\\ | o | o ) ( (( o ) |_| o | o ( o )   / o | o | o )   /       \r\n                |___/___|_| |_|  \\_/|_|_|\\_|__/ \\_/   \\__\\_/|___|_n_|___/\\_/|_|\\\\_n_|__/ \\_/|_|\\\\ ()()()                                                                                                                                                                                                \r\n                    ___ ___ _  _ _ _  _    _ _ _   _   // ___ _ _   _  _    __  _  _   ||||||\r\n                   |_ _| __| \\| | U |/ \\  | | | \\_/ |  / \\_ _| | \\_/ |/ \\  |  \\| |/ \\  L|L|L|\r\n                    | || _|| \\\\ |   | o | | U | \\_/ | ( o ) || | \\_/ ( o ) | o ) | o |       \r\n                    |_||___|_|\\_|_n_|_n_| |___|_| |_|  \\_/|_||_|_| |_|\\_/  |__/|_|_n_| ()()()\r\n                                                                          \r\n \r\n     _ _  _   __ /^\\   //_   __   _    ___ _  _   _  _  _  _ _ _  _    __   _    __ ___ _ _   __  _  _  _ _ _  _  \r\n    | | |/ \\ / _| __| | __| |  \\ / \\  |_ _/ \\| \\_/ |/ \\| \\| | U |/ \\  |  \\ / \\  / _| __| | | / _|/ \\| \\| | U |/ \\ \r\n    | V ( o | (_| _|  | _|  | o | o )  | | o | \\_/ | o | \\\\ |   ( o ) | o | o ) \\_ \\ _|| U | \\_ ( o ) \\\\ |   ( o )\r\n     \\_/ \\_/ \\__|___| |___| |__/ \\_/   |_|_n_|_| |_|_n_|_|\\_|_n_|\\_/  |__/ \\_/  |__/___|___| |__/\\_/|_|\\_|_n_|\\_/ \r\n                                                                                                              \r\n                      _   __ ___ ___ __  _ ___ ___   ___ _   _   __ _   _   _ ___ __ _   _  _   ||||||\r\n                     / \\ / _| o \\ __|  \\| |_ _| __| | __| \\_/ | / _| | | \\_/ | __/ _| \\_/ |/ \\  L|L|L|\r\n                    | o ( (_|   / _|| o ) || || _|  | _|| \\_/ | \\_ \\ | | \\_/ | _|\\_ \\ \\_/ ( o )       \r\n                    |_n_|\\__|_|\\\\___|__/|_||_||___| |___|_| |_| |__/_| |_| |_|___|__/_| |_|\\_/  ()()()\r\n");
            string usuario = "NatanaelBarboza"; // USUÁRIO PADRÃO, POR ENQUANTO
            string senha = "SHARPBANK"; // SENHA PADRÃO, POR ENQUANTO

            Console.Write("                                     DIGITE SEU LOGIN DE ACESSO: ");
            string entradaLogin = Console.ReadLine();
            Console.WriteLine();
            Console.Write("                                     DIGITE SUA SENHA: ");
            string entradaSenha = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i <= 3; i++)
            {
                if (entradaLogin == usuario && entradaSenha == senha)
                {
                    
                    Console.Clear();
                    Telas.SegundaTelaDeInicio();
                    MenuDeOpcoesBack();
                    TerceiroBack(CPF, Nome, Senha, Saldo, Conta, CV);
                    break;

                }
                else if (i == 3)
                {
                    Console.Clear();
                    Console.WriteLine("                 ___ ___ _   _   _ _ _ _  _ __   _     __ _  _    _  ___  _  ___  _  __   _  ___  ||||||\r\n                | o ) __| \\_/ | | | | | \\| |  \\ / \\   / _/ \\| |  / \\| o )/ \\| o \\/ \\|  \\ / \\| o \\ L|L|L|\r\n                | o \\ _|| \\_/ | | V | | \\\\ | o | o ) ( (( o ) |_| o | o ( o )   / o | o | o )   /       \r\n                |___/___|_| |_|  \\_/|_|_|\\_|__/ \\_/   \\__\\_/|___|_n_|___/\\_/|_|\\\\_n_|__/ \\_/|_|\\\\ ()()()                                                                                                                                                                                                \r\n                    ___ ___ _  _ _ _  _    _ _ _   _   // ___ _ _   _  _    __  _  _   ||||||\r\n                   |_ _| __| \\| | U |/ \\  | | | \\_/ |  / \\_ _| | \\_/ |/ \\  |  \\| |/ \\  L|L|L|\r\n                    | || _|| \\\\ |   | o | | U | \\_/ | ( o ) || | \\_/ ( o ) | o ) | o |       \r\n                    |_||___|_|\\_|_n_|_n_| |___|_| |_|  \\_/|_||_|_| |_|\\_/  |__/|_|_n_| ()()()\r\n                                                                          \r\n \r\n     _ _  _   __ /^\\   //_   __   _    ___ _  _   _  _  _  _ _ _  _    __   _    __ ___ _ _   __  _  _  _ _ _  _  \r\n    | | |/ \\ / _| __| | __| |  \\ / \\  |_ _/ \\| \\_/ |/ \\| \\| | U |/ \\  |  \\ / \\  / _| __| | | / _|/ \\| \\| | U |/ \\ \r\n    | V ( o | (_| _|  | _|  | o | o )  | | o | \\_/ | o | \\\\ |   ( o ) | o | o ) \\_ \\ _|| U | \\_ ( o ) \\\\ |   ( o )\r\n     \\_/ \\_/ \\__|___| |___| |__/ \\_/   |_|_n_|_| |_|_n_|_|\\_|_n_|\\_/  |__/ \\_/  |__/___|___| |__/\\_/|_|\\_|_n_|\\_/ \r\n                                                                                                              \r\n                      _   __ ___ ___ __  _ ___ ___   ___ _   _   __ _   _   _ ___ __ _   _  _   ||||||\r\n                     / \\ / _| o \\ __|  \\| |_ _| __| | __| \\_/ | / _| | | \\_/ | __/ _| \\_/ |/ \\  L|L|L|\r\n                    | o ( (_|   / _|| o ) || || _|  | _|| \\_/ | \\_ \\ | | \\_/ | _|\\_ \\ \\_/ ( o )       \r\n                    |_n_|\\__|_|\\\\___|__/|_||_||___| |___|_| |_| |__/_| |_| |_|___|__/_| |_|\\_/  ()()()\r\n");
                    Console.WriteLine("                                     VOCÊ TENTOU TRÊS VEZES.\n");
                    Console.WriteLine("                                     POR SEGURANÇA SUA SESSÃO SERÁ ENCERRADA\n");
                    Console.WriteLine("                                     AGRADECEMOS A SUA COMPREENSÃO\n\n");
                    Console.Write("                                     APERTE QUALQUER TECLA PARA CONTINUAR\n");
                    Console.ReadKey();
                    Telas.MenuInicial();
                    break;
                }
                else
                {

                    Console.Clear();
                    Console.WriteLine("                 ___ ___ _   _   _ _ _ _  _ __   _     __ _  _    _  ___  _  ___  _  __   _  ___  ||||||\r\n                | o ) __| \\_/ | | | | | \\| |  \\ / \\   / _/ \\| |  / \\| o )/ \\| o \\/ \\|  \\ / \\| o \\ L|L|L|\r\n                | o \\ _|| \\_/ | | V | | \\\\ | o | o ) ( (( o ) |_| o | o ( o )   / o | o | o )   /       \r\n                |___/___|_| |_|  \\_/|_|_|\\_|__/ \\_/   \\__\\_/|___|_n_|___/\\_/|_|\\\\_n_|__/ \\_/|_|\\\\ ()()()                                                                                                                                                                                                \r\n                    ___ ___ _  _ _ _  _    _ _ _   _   // ___ _ _   _  _    __  _  _   ||||||\r\n                   |_ _| __| \\| | U |/ \\  | | | \\_/ |  / \\_ _| | \\_/ |/ \\  |  \\| |/ \\  L|L|L|\r\n                    | || _|| \\\\ |   | o | | U | \\_/ | ( o ) || | \\_/ ( o ) | o ) | o |       \r\n                    |_||___|_|\\_|_n_|_n_| |___|_| |_|  \\_/|_||_|_| |_|\\_/  |__/|_|_n_| ()()()\r\n                                                                          \r\n \r\n     _ _  _   __ /^\\   //_   __   _    ___ _  _   _  _  _  _ _ _  _    __   _    __ ___ _ _   __  _  _  _ _ _  _  \r\n    | | |/ \\ / _| __| | __| |  \\ / \\  |_ _/ \\| \\_/ |/ \\| \\| | U |/ \\  |  \\ / \\  / _| __| | | / _|/ \\| \\| | U |/ \\ \r\n    | V ( o | (_| _|  | _|  | o | o )  | | o | \\_/ | o | \\\\ |   ( o ) | o | o ) \\_ \\ _|| U | \\_ ( o ) \\\\ |   ( o )\r\n     \\_/ \\_/ \\__|___| |___| |__/ \\_/   |_|_n_|_| |_|_n_|_|\\_|_n_|\\_/  |__/ \\_/  |__/___|___| |__/\\_/|_|\\_|_n_|\\_/ \r\n                                                                                                              \r\n                      _   __ ___ ___ __  _ ___ ___   ___ _   _   __ _   _   _ ___ __ _   _  _   ||||||\r\n                     / \\ / _| o \\ __|  \\| |_ _| __| | __| \\_/ | / _| | | \\_/ | __/ _| \\_/ |/ \\  L|L|L|\r\n                    | o ( (_|   / _|| o ) || || _|  | _|| \\_/ | \\_ \\ | | \\_/ | _|\\_ \\ \\_/ ( o )       \r\n                    |_n_|\\__|_|\\\\___|__/|_||_||___| |___|_| |_| |__/_| |_| |_|___|__/_| |_|\\_/  ()()()\r\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("                                     USUÁRIO OU SENHA INCORRETOS\n\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("                                     DIGITE SEU LOGIN DE ACESSO: ");
                    entradaLogin = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("                                     DIGITE SUA SENHA: ");
                    entradaSenha = Console.ReadLine();
                }
            }

        }

        public static void MenuDeOpcoesBack()
        {
            Console.Clear();
            Telas.SegundaTelaDeInicio();
            Console.WriteLine("\n                                     1 - LISTA TODAS AS CONTAS");
            Console.WriteLine("                                     2 - DETALHES DE UMA CONTA");
            Console.WriteLine("                                     3 - CAIXA DO BANCO");
            Console.WriteLine("                                     0 - RETONAR AO MENU INICIAL");
            Console.WriteLine();
            Console.Write("                                     DIGITE UMA DAS OPÇÕES ACIMA: ");
        }


        public static void CaixaBanco(List<string> CPF, List<string> Nome, List<string> Senha, List<double> Saldo, List<int> Conta, List<int> CV)
        {
            Console.WriteLine();
            double SaldoCaixaBanco = 0;
            int contagemDeContas = 0;

            for (int i = 0; i < CPF.Count; i++)
            {

                SaldoCaixaBanco += Saldo[i];
                contagemDeContas++;

            }
            Console.WriteLine($"                     ATUALEMNTE O SHARPBANK POSSUI {contagemDeContas} CLIENTE(S) CADASTRADO(S)\n");
            Console.WriteLine($"                     O VALOR TOTAL NO CAIXA DO SHARPBANK É DE R$ {SaldoCaixaBanco:f2}\n");
            Console.WriteLine("                     PRECIONE QUALQUER TECLA PARA CONTINUAR: ");
            Console.ReadKey();

        }

        public static void ListaContas(List<string> CPF, List<string> Nome, List<string> Senha, List<double> Saldo, List<int> Conta, List<int> CV)
        {
            Console.WriteLine();
            int contagemDeContas = 0;
            for (int i = 0; i < CPF.Count; i++)
            {
                contagemDeContas++;
                Console.WriteLine("                 -----------------------------------------------------------------");
                Console.WriteLine($"                     AGÊNCIA: 777  CONTA: {Conta[i]} CV: {CV[i]} \n");
                Console.WriteLine($"                     CPF: {CPF[i]}\n");
                Console.WriteLine($"                     NOME: {Nome[i]}\n");
                Console.WriteLine($"                     SALDO: R$ {Saldo[i]:f2}\n");
                Console.WriteLine("                 -----------------------------------------------------------------");

            }
            Console.WriteLine($"                     ATUALEMNTE O SHARPBANK POSSUI {contagemDeContas} CLIENTE(S) CADASTRADO(S)\n\n");
            Console.Write("                     APERTE QUALQUER TECLA PARA CONTINUAR: ");
            Console.ReadKey();

        }
        public static void DetalhesdaConta(List<string> CPF, List<string> Nome, List<string> Senha, List<double> Saldo, List<int> Conta, List<int> CV)
        {
            Console.WriteLine();
            Console.Write("                     INFORME O CPF QUE DESEJA ACESSAR: "); // VER PARA DIGITAR USUÁRIO E SENHA SÓ UMA VEZ
            string entradaCPF = Console.ReadLine();

            int j = 0;

            for (int i = 0; i < CPF.Count; i++)
            {

                if (CPF[i] == entradaCPF)
                {
                    j++;
                    Console.Clear();
                    Telas.SegundaTelaDeInicio();
                    Console.WriteLine($"                     AGÊNCIA: 777  CONTA: {Conta[i]} CV: {CV[i]} \n");
                    Console.WriteLine($"                     CPF: {CPF[i]}  \n");
                    Console.WriteLine($"                     NOME: {Nome[i]}  \n");
                    Console.WriteLine($"                     SALDO: R$ {Saldo[i]:f2}\n");
                    Console.Write("                     APERTE QUALQUER TECLA PARA CONTINUAR");
                    Console.ReadKey();

                }


            }
            if (j == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                     CPF NÃO LOCALIZADO\n");
                Console.WriteLine("                     PARA SUA SEGURANÇA A SESSÃO ESTÁ SENDO ENCERRADA\n");
                Console.WriteLine("                     AGRADECEMOS A SUA COMPREENÇÃO\n");
                Console.Write("                     APERTE QUALQUER TECLA PARA CONTINUAR");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;

            }
        }
        public static void TerceiroBack(List<string> CPF, List<string> Nome, List<string> Senha, List<double> Saldo, List<int> Conta, List<int> CV)
        {

            string entradaEditar;

            do
            {
                MenuDeOpcoesBack();

                string entradaTerceiroMenuBack = Console.ReadLine();

                while (entradaTerceiroMenuBack != "0" && entradaTerceiroMenuBack != "1" && entradaTerceiroMenuBack != "2" && entradaTerceiroMenuBack != "3")
                {
                    MenuDeOpcoesBack();
                    entradaTerceiroMenuBack = Console.ReadLine();

                }
                entradaEditar = entradaTerceiroMenuBack;
                switch (entradaTerceiroMenuBack)
                {
                    case "0":
                        Console.Clear();
                        Telas.MenuInicial();

                        break;
                    case "1":
                        Console.Clear();
                        Telas.SegundaTelaDeInicio();
                        ListaContas(CPF, Nome, Senha, Saldo, Conta, CV);
                        break;

                    case "2":
                        Console.Clear();
                        Telas.SegundaTelaDeInicio();
                        DetalhesdaConta(CPF, Nome, Senha, Saldo, Conta, CV);
                        break;

                    case "3":

                        Console.Clear();
                        Telas.SegundaTelaDeInicio();
                        CaixaBanco(CPF, Nome, Senha, Saldo, Conta, CV);
                        break;

                }

            } while (entradaEditar != "0");


        }
    }
}
