using System;

namespace ReadCalculo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            int soma;
            Console.WriteLine("Digite um numero");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero");
            b=int.Parse(Console.ReadLine());
            soma=a+b;

            Console.WriteLine(soma);
        }
    }
}
