using System;
using System.Globalization;

namespace _1036
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num =Console.ReadLine().Split(' ');

            double A = double.Parse(num[0],CultureInfo.InvariantCulture);
            double B = double.Parse(num[1],CultureInfo.InvariantCulture);
            double C = double.Parse(num[2],CultureInfo.InvariantCulture);

            if(A == 0.0 || B == 0.0 || C == 0.0 ){
                Console.WriteLine("Impossivel calcular");
            }else{
            double formulaP = (-B+Math.Sqrt(B*B -4*A*C))/(2*A);
            double formulaN = (-B-Math.Sqrt(B*B -4*A*C))/(2*A);

            if(Double.IsNaN(formulaN) || Double.IsNaN(formulaP)){
                Console.WriteLine("Impossivel calcular");
            }else{
            
            Console.WriteLine("R1 = "+formulaP.ToString("F5",CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = "+formulaN.ToString("F5",CultureInfo.InvariantCulture));
            }
            }
        }
    }
}
