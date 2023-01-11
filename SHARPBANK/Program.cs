using System;
using System.Globalization;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace SHARPBANK
{

    

    public class Program

    {
        static void Main(string[] args)
        {
            List<string> CPF = new List<string>();
            List<string> Nome = new List<string>();
            List<string> Senha = new List<string>();
            List<double> Saldo = new List<double>();
            List<int> Conta = new List<int>();
            List<int> CV = new List<int>();
            string testeEntradaCPFDoCliente = string.Empty;


            string entradaMenuInicia;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Telas.MenuInicial();

                entradaMenuInicia = Console.ReadLine();
                
                while (entradaMenuInicia != "0" && entradaMenuInicia != "1" && entradaMenuInicia != "2")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Telas.MenuInicial();
                    entradaMenuInicia = Console.ReadLine();

                }

                switch (entradaMenuInicia)
                {
                    case "0":
                        break;
                    case "1":
                        Console.Clear();
                        Telas.SegundaTelaDeInicio();
                        Console.WriteLine();
                        Telas.MenuCliente();

                        string entradaSecundariaPrincipal = Console.ReadLine();
                        while (entradaSecundariaPrincipal != "0" && entradaSecundariaPrincipal != "1" && entradaSecundariaPrincipal != "2")
                        {
                            Console.Clear();
                            Telas.SegundaTelaDeInicio();
                            Console.WriteLine();
                            Telas.MenuCliente();
                            entradaSecundariaPrincipal = Console.ReadLine();

                        }

                        switch (entradaSecundariaPrincipal)
                        {
                            case "0":
                                Console.Clear();
                                Telas.TelaDenicio();
                                Telas.MenuInicial();
                                break;
                            case "1":
                                Console.Clear();
                                Telas.SegundaTelaDeInicio();
                                Cliente.NovoCliente(CPF, Nome, Senha, Saldo, Conta, CV);

                                break;
                            case "2":
                                Console.Clear();
                                Telas.SegundaTelaDeInicio();
                                EntrarNaConta.AcessarConta(CPF, Nome, Senha, Saldo, Conta, CV);
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Colaborador.MenuDeOpcoesBack();
                        Colaborador.InicioBack(CPF, Nome, Senha, Saldo, Conta, CV);                        

                        break;
                }

            } while (entradaMenuInicia != "0");

        }
        

    }

}