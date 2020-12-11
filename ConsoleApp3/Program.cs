using System;
using System.Globalization;
using System.Collections.Generic;

namespace Projeto
{
    class Program
    {
        public static void Main(String[] args)
        {
            Calculadora calc = new Calculadora();

            calc.Menu();
            Console.Read();
        }

    }

}