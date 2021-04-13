using System;
using System.Globalization;
namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            double product1=double.Parse(vet[1],CultureInfo.InvariantCulture)*double.Parse(vet[2],CultureInfo.InvariantCulture);
            double product2=double.Parse(vet2[1],CultureInfo.InvariantCulture)*double.Parse(vet2[2],CultureInfo.InvariantCulture);
            double TOTAL=product1+product2;

            Console.WriteLine("VALOR A PAGAR: R$ "+TOTAL.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
