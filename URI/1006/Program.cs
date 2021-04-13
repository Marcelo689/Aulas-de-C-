using System;
using System.Globalization;

namespace _1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A,B,C;

            A= double.Parse(Console.ReadLine());
            B= double.Parse(Console.ReadLine());
            C= double.Parse(Console.ReadLine());

            double MEDIA = (A*2+B*3+C*5)/10;

            Console.WriteLine("MEDIA = "+MEDIA.ToString("F1",CultureInfo.InvariantCulture));
        }
    }
}
