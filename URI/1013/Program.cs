using System;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array= Console.ReadLine().Split(' ');

            int a =int.Parse(array[0]);
            int b =int.Parse(array[1]);
            int c =int.Parse(array[2]);

            int maior=((a+b)+Math.Abs((a-b)))/2;
            int maior2=((maior+c)+Math.Abs(maior-c))/2;
            Console.WriteLine(maior2+" eh o maior");
        }
    }
}
