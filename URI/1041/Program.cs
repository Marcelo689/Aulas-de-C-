using System;
using System.Globalization;

namespace _1041
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input= Console.ReadLine().Split(' ');

            double x =double.Parse(input[0],CultureInfo.InvariantCulture);
            double y =double.Parse(input[1],CultureInfo.InvariantCulture);

            if(x == 0.0 && y == 0.0){
                Console.WriteLine("Origem");
            }else if(x == 0.0){
                Console.WriteLine("Eixo Y");
            }else if(y == 0.0){
                Console.WriteLine("Eixo X");
            }else{

            if(x == Math.Abs(x)){// x positivo
            if(y == Math.Abs(y)){
                Console.WriteLine("Q1");
            }else{
                Console.WriteLine("Q4");
            }
            }else{// x negativo
            if(y == Math.Abs(y)){
                Console.WriteLine("Q2");
            }else{
                Console.WriteLine("Q3");
            }
            }
            }
        }
    }
}
