using System;
using System.Globalization;

namespace _1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double MEDIA=((nota1*3.5)+(nota2*7.5))/11;

            Console.WriteLine("MEDIA = "+MEDIA.ToString("F5",CultureInfo.InvariantCulture));

        }
    }
}
