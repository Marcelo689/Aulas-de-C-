using System;
using System.Globalization;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMBER =int.Parse(Console.ReadLine());
            int  hoursWorked=int.Parse(Console.ReadLine());
            double hoursPrice =double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double SALARY = (double)hoursWorked*hoursPrice;

            Console.WriteLine("NUMBER = "+NUMBER);
            Console.WriteLine("SALARY = U$ "+SALARY.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
