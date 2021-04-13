using System;
using System.Globalization;

namespace EXERCICIOTERRENO
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura,comprimento,precoMetroQuadrado,area,precoTotalTerreno;

            largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            precoMetroQuadrado = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            area = largura*comprimento;

            precoTotalTerreno=precoMetroQuadrado*area;

            Console.WriteLine("AREA ="+area.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO ="+precoTotalTerreno.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
