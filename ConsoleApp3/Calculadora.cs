using System;
using System.Collections.Generic;

namespace Projeto
{
    public class Calculadora
    {
        private List<double> listaNumeros = new List<double>();

        public List<double> RetornaLista(string operacao)      //Método para ler os números a serem calculados
        {
            string tipoOperacao = operacao;

            Console.WriteLine($"\n[{tipoOperacao}] Informe os números a serem calculados (Digite '=' para calcular): \n");
            string n = Console.ReadLine();
            TestaNumero(tipoOperacao, n);

            return listaNumeros;
        }

        private string TestaNumero(string operacao, string n)
        {
            while (n != "=")
            {
                double testeNum = 0;

                if (double.TryParse(n, out testeNum) && n.Length != 0)   // Teste se o valor digitado é numero e se está vazio
                {
                    if (operacao == "Dividir")
                    {
                        while (n == "0")
                        {
                            Console.WriteLine("Não é possível dividir por zero! Tente outro valor: ");
                            n = Console.ReadLine();
                        }
                        listaNumeros.Add(double.Parse(n));
                        n = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Informe um número válido!");
                    n = Console.ReadLine();
                }


            }

            return n;
        }

        public void Somar()
        {
            List<double> listaSomar = RetornaLista("Somar");

            double resultado = 0.0;

            foreach (double numero in listaSomar)
            {
                resultado += numero;
            }

            Console.WriteLine($"{resultado}\n");
            ResetaLista();
        }

        public void Subtrair()
        {
            List<double> listaSubtrair = RetornaLista("Subtrair");

            double resultado = 0.0;

            foreach (double numero in listaSubtrair)
            {
                if (numero == listaSubtrair[0])     /* Verifica se é o primeiro valor digitado e 
                                                       começa a subtrair a partir dele. */
                {
                    resultado = numero;
                }
                else
                {
                    resultado -= numero;
                }

            }

            Console.WriteLine($"{resultado}\n");
            ResetaLista();
        }

        public void Multiplicar()
        {
            List<double> listaMultiplicar = RetornaLista("Multiplicar");

            double resultado = 0.0;
            foreach (double numero in listaMultiplicar)
            {
                if (numero == listaMultiplicar[0])      /* Verifica se é o primeiro valor digitado e 
                                                           começa a multiplicar a partir dele. */
                {
                    resultado = numero;
                }
                else
                {
                    resultado *= numero;
                }
            }
            Console.WriteLine($"{resultado}\n");
            ResetaLista();

        }

        public void Dividir()
        {
            List<double> listaDividir = RetornaLista("Dividir");

            double resultado = 0.0;

            foreach (double numero in listaDividir)
            {
                for (int i = 0; i < listaDividir.Count; i++)
                {
                    if (i == 0)
                    {
                        resultado = listaDividir[0];
                    }
                    else
                    {
                        resultado /= listaDividir[i];
                    }

                }
                Console.WriteLine($"{resultado}\n");
                break;
            }
            ResetaLista();
        }

        public void ResetaLista()           /* Zera a lista de números para não acumular 
                                               valores antigos com as novas operacoes */
        {
            listaNumeros.Clear();
        }

        public void Menu()
        {
            Console.WriteLine(">> Menu Calculadora");
            Console.WriteLine("\n" +
                "[1] Soma\n" +
                "[2] Subtrair\n" +
                "[3] Multiplicar\n" +
                "[4] Dividir\n" +
                "[0] Sair\n");
            Console.Write("Opção: ");
            string resposta = Console.ReadLine();

            while (true)
            {
                switch (resposta)
                {
                    case "1":
                        Somar();
                        break;

                    case "2":
                        Subtrair();
                        break;

                    case "3":
                        Multiplicar();
                        break;

                    case "4":
                        Dividir();
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;
                }
                Menu();
            }

        }
    }
}