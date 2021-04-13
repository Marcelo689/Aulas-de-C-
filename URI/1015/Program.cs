using System;
using System.Globalization;

namespace _1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet1 =Console.ReadLine().Split(' ');
            string[] vet2 =Console.ReadLine().Split(' ');

            double x1 =double.Parse(vet1[0],CultureInfo.InvariantCulture);
            double y1 =double.Parse(vet1[1],CultureInfo.InvariantCulture);
            double x2 =double.Parse(vet2[0],CultureInfo.InvariantCulture);
            double y2 =double.Parse(vet2[1],CultureInfo.InvariantCulture);

            double resto = Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2);
            double distance =Math.Sqrt(resto);
            Console.WriteLine(distance.ToString("F4",CultureInfo.InvariantCulture));

        }
    }
}
