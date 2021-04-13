using System;
using System.Globalization;
namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double result =km/fuel;
            Console.WriteLine(result.ToString("F3",CultureInfo.InvariantCulture)+ " km/l");
        }
    }
}
