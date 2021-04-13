using System;

namespace EXERCICIORESOLVIDO1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.0;
            double y = 4.0;
            double z =-5.0;
            double A,B,C;

            //Raiz Quadrada
            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);
            Console.WriteLine("A raiz quadrada de "+x+" = "+A);
            Console.WriteLine("A raiz quadrada de "+y+" = "+B);
            Console.WriteLine("A raiz quadrada de 25.0  = "+C);
            
            //Potência
            A =Math.Pow(x,y);
            B =Math.Pow(x,2.0);
            C =Math.Pow(5.0,2.0);

            Console.WriteLine(x+" elevado a "+y+" = "+A);
            Console.WriteLine(x+" elevado a 2.0 = "+B);
            Console.WriteLine("5.0 elevado a 2.0 = "+C);

            //Valor absoluto
            A=Math.Abs(x);
            B=Math.Abs(z);
            Console.WriteLine("O valor absoluto de "+ x +" é = "+A);
            Console.WriteLine("O valor absoluto de " +z +" é = "+B);
        }
    }
}
