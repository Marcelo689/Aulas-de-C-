using System;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            Console.WriteLine("Digite uma frase");
            frase= Console.ReadLine();


                
            Console.WriteLine(frase);

            string[]vet=frase.Split(" ");

            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            for(var i=0;i<vet.Length;i++){
                Console.WriteLine(vet[i]);
            }
        }
    }
}
