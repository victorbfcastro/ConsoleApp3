using System;
using System.Globalization;

namespace Projeto
{  
    class Program
    { 
        public static void Main(String[] args)
        {
            Calculadora calc;
            calc = new Calculadora();

            double[] numeros = { 1.2, 1.3, 1.4, 2.4, 4.4 };

            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = calc.Soma(n1, n2);
            Console.WriteLine("resultado 1 = " + resultado);


            double resultado2 = calc.Soma(numeros);
            Console.WriteLine("resultado 2 =" + resultado2);


            Console.Read();
        }
    }

}