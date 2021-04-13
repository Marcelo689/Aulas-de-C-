using System;

namespace _1042
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] input = Console.ReadLine().Split(' ');

           int num1 = int.Parse(input[0]);
           int num2 = int.Parse(input[1]);
           int num3 = int.Parse(input[2]);

            int[] num ={num1,num2,num3};
            // Ordem crescente
           Array.Sort(num);
           for(int i =0;i<num.Length;i++){
               Console.WriteLine(num[i]);
           }
           Console.WriteLine();
            // Ordem inicial do array
           
           for(int i =0;i<input.Length;i++){
               Console.WriteLine(input[i]);
           }

        }
    }
}
