using System;

namespace CheckListNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro");
            int num =int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um char");
            char caracter =char.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero double");
            double numDouble =double.Parse(Console.ReadLine());
           
            Console.WriteLine("Digite seu nome,sexo,idade,altura separado por espaços");
            string[] vet=Console.ReadLine().Split(" ");
            string nome =vet[0];
            char sexo =char.Parse(vet[1]);
            int idade =int.Parse(vet[2]);
            double altura=double.Parse(vet[3]);

            Console.WriteLine("Voce digitou :");
            Console.WriteLine(num);
            Console.WriteLine(caracter);
            Console.WriteLine(numDouble);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
