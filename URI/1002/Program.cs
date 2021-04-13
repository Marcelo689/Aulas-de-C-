using System;
using System.Globalization;
namespace _1002
{
    class Program
    {
        static void Main(string[] args)
        {
        double n = 3.14159;
        double R = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        double A = n*Math.Pow(R,2);
        
        Console.WriteLine("A="+A.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
