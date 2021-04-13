using System;
using System.Globalization;
namespace _1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi=3.14159;
            string[] vet =Console.ReadLine().Split(' ');
            double A =double.Parse(vet[0],CultureInfo.InvariantCulture);
            double B =double.Parse(vet[1],CultureInfo.InvariantCulture);
            double C =double.Parse(vet[2],CultureInfo.InvariantCulture);

            double triangle  = (A*C)/2 ;
            double circle   = pi*Math.Pow(C,2);
            double trapezium = ((A+B)*C)/2;
            double square = B*B;
            double rectangle = A*B;

            Console.WriteLine("TRIANGULO: "+triangle.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: "+circle.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: "+trapezium.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: "+square.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: "+rectangle.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
