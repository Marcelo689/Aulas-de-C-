using System;

namespace TESTEVARIAVEIS1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            double y = 11.5;
            char sexo = 'M';
            string nome= "Marcelo";
            Console.WriteLine("{0}", x);
            Console.WriteLine("{0:f1}", y);
            Console.WriteLine("seu nome é {0}",nome);
            Console.WriteLine("do sexo {0}",sexo);
        }
    }
}
