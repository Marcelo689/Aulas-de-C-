using System;
using System.Globalization;
namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int hours =int.Parse(Console.ReadLine());
            int kmH =int.Parse(Console.ReadLine());
            double km =hours*kmH;

            double litros = km/12;

            Console.WriteLine(litros.ToString("F3",CultureInfo.InvariantCulture));

        }
    }
}
