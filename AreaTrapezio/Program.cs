using System;

namespace TesteVariaveis2
{
    class Program
    {
        static void Main(string[] args)
        {
           double b,B,altura,area;

            b=5;
            B=6;
            altura=12;

            // Console.WriteLine("Digite a base menor");
            // b=Console.ReadLine();
            // Console.WriteLine("Digite a base maior");
            // B=Console.ReadLine();
            // Console.WriteLine("Digite a altura");
            // altura=Console.ReadLine();

            area=((b+B)*altura)/2;

            Console.WriteLine("A area do trapezio eh {0}",area);
        }
    }
}
