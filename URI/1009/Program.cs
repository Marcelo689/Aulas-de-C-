using System;
using System.Globalization;
namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double sale =double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double finalSalary = salary+((sale*15)/100);

            Console.WriteLine("TOTAL = R$ "+finalSalary.ToString("F2",CultureInfo.InvariantCulture));
            
        }
    }
}
