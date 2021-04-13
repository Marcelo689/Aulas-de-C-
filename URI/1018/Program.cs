using System;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] banknotes = {100,50,20,10,5,2,1};
            int[] qtdNotes ={0,0,0,0,0,0,0};
            int input =int.Parse(Console.ReadLine());
            int inputTotal= input;

            if(input>=banknotes[0]){
                qtdNotes[0] =input/100;
                input= input % 100;
                
            }
            if(input>=banknotes[1]){
                qtdNotes[1] =input/50;
                input= input % 50;
                
            }
            if(input>=banknotes[2]){
                qtdNotes[2] =input/20;
                input= input % 20;
                
            }
            if(input>=banknotes[3]){
                qtdNotes[3] =input/10;
                input= input % 10;
                
            }
            if(input>=banknotes[4]){
                qtdNotes[4] =input/5;
                input= input % 5;
                
            }
            if(input>=banknotes[5]){
                qtdNotes[5] =input/2;
                input= input % 2;
                
            }
            if(input>=banknotes[6]){
                qtdNotes[6] =input/1;
                input= input % 1;
                
            }
            if(input == 0){
                Console.WriteLine(inputTotal);
                Console.WriteLine(qtdNotes[0]+" nota(s) de R$ 100,00");
                Console.WriteLine(qtdNotes[1]+" nota(s) de R$ 50,00");
                Console.WriteLine(qtdNotes[2]+" nota(s) de R$ 20,00");
                Console.WriteLine(qtdNotes[3]+" nota(s) de R$ 10,00");
                Console.WriteLine(qtdNotes[4]+" nota(s) de R$ 5,00");
                Console.WriteLine(qtdNotes[5]+" nota(s) de R$ 2,00");
                Console.WriteLine(qtdNotes[6]+" nota(s) de R$ 1,00");
            }
        }
    }
}
