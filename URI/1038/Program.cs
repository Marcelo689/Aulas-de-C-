using System;
using System.Globalization;

namespace _1038
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] items;
            items = new double[6];
            items[1]=4.00;
            items[2]=4.50;
            items[3]=5.00;
            items[4]=2.00;
            items[5]=1.50;

            string[] values = Console.ReadLine().Split(' ');
            int comida= int.Parse(values[0]);
            double qtd = double.Parse(values[1],CultureInfo.InvariantCulture);

            double custo =qtd*items[comida];

            Console.WriteLine("Total: R$ "+custo.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
