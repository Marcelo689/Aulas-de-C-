using System;

namespace _1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int input =int.Parse(Console.ReadLine());

            int ano = input/365;
            int mes = (input%365)/30;
            int dia = (input%365)%30;

            Console.WriteLine(ano+" ano(s)");
            Console.WriteLine(mes+" mes(es)");
            Console.WriteLine(dia+" dia(s)");
        }
    }
}
