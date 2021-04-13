using System;
using System.Globalization;

namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi =3.14159;
            double R = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double Result =(4.0/3)*pi*Math.Pow(R,3);

            Console.WriteLine("VOLUME = "+Result.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
