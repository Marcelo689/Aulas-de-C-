using System;

namespace CheckList
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;

            Console.WriteLine("Digite uma string  ");
            s = Console.ReadLine();

            string a,b,c;

            Console.Write("Digite a primeira Palavra  ");
            a = Console.ReadLine();
            
            Console.Write("Digite a segunda Palavra  ");
            b = Console.ReadLine();
            
            Console.Write("Digite a terceira Palavra  ");
            c = Console.ReadLine();

            Console.WriteLine("Digite uma frase com 3 palavras");
            string[] frase = Console.ReadLine().Split(" ");

            string x,y,z;

            x=frase[0];
            y=frase[1];
            z=frase[2];

            Console.WriteLine("Voce digitou:");
            Console.WriteLine(s);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(frase); 
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
