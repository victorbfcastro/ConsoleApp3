namespace Projeto
{
    public class Calculadora
    {
        // Soma(double n1, double n2)
        public double Soma(double n1, double n2)
        {
            return n1 + n2;
        }
        public double Soma(params double[] numeros)
        {
            double resultado = 0.0;
            foreach (double numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }
    }
}