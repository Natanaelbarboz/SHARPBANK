using System;
using System.Globalization;
using System.Security.Claims;
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

            int entradaMenuPrincipal;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Front.MenuInicial();

                string entradaMenuInicia = Console.ReadLine();

                while (entradaMenuInicia == "")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Front.MenuInicial();
                    entradaMenuInicia = Console.ReadLine();
                }

                entradaMenuPrincipal = int.Parse(entradaMenuInicia);

                while (entradaMenuPrincipal != 0 && entradaMenuPrincipal != 1 && entradaMenuPrincipal != 2)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Front.MenuInicial();
                    entradaMenuPrincipal = int.Parse(Console.ReadLine());

                }

                switch (entradaMenuPrincipal)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Clear();
                        Front.SegundaTelaDeInicio();
                        Console.WriteLine();
                        Front.MenuCliente();

                        string entradaSecundariaString = Console.ReadLine();

                        while (entradaSecundariaString == "")
                        {
                            Console.Clear();
                            Front.SegundaTelaDeInicio();
                            Console.WriteLine();
                            Front.MenuCliente();
                            entradaSecundariaString = Console.ReadLine();
                        }

                        int entradaSecundariaPrincipal = int.Parse(entradaSecundariaString);
                        
                        while (entradaSecundariaPrincipal != 0 && entradaSecundariaPrincipal != 1 && entradaSecundariaPrincipal != 2)
                        {
                            Console.Clear();
                            Front.SegundaTelaDeInicio();
                            Console.WriteLine();
                            Front.MenuCliente();
                            entradaSecundariaPrincipal = int.Parse(Console.ReadLine());

                        }

                        switch (entradaSecundariaPrincipal)
                        {
                            case 0:
                                Console.Clear();
                                Front.TelaDenicio();
                                Front.MenuInicial();
                                break;
                            case 1:
                                Console.Clear();
                                Front.SegundaTelaDeInicio();
                                Cliente.NovoCliente(CPF, Nome, Senha, Saldo);

                                break;
                            case 2:
                                Console.Clear();
                                Front.SegundaTelaDeInicio();
                                EntrarNaConta.AcessarConta(CPF, Nome, Senha, Saldo);
                                break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        BackEnd.MenuDeOpcoesBack();
                        BackEnd.InicioBack(CPF, Nome, Senha, Saldo);                        

                        break;
                }

            } while (entradaMenuPrincipal != 0);

        }

    }

}