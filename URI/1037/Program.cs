using System;
using System.Globalization;
namespace _1037
{
    class Program
    {
        static void Main(string[] args)
        {
           double num = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
           
           // checa se o valor esta entre 0 e 100
           if(num < 0.0 || num > 100.00){
               Console.WriteLine("Fora de intervalo");
           }

            // checa de 0 a 25
           if(num >= 0.00 && num <= 25.00){
               if(num > 0.00 && num != 25.00){
               Console.WriteLine("Intervalo (0,25]");
                
               }else{
               Console.WriteLine("Intervalo [0,25]");
                
               }
           }
           // checa de 25 a 50
           if(num > 25.00 && num <= 50.00){
               if(num > 25.00){
               Console.WriteLine("Intervalo (25,50]");
               
               }else{
               Console.WriteLine("Intervalo [25,50]");
               
               }
           }
           // checa de 50 a 75
           if(num > 50.00 && num <= 75.00 ){
               if(num > 50.00){
               Console.WriteLine("Intervalo (50,75]");
                
               }else{
               Console.WriteLine("Intervalo [50,75]");
               
               }
           }
            // checa de 75 a 100
           if(num > 75.00 && num <= 100.00 ){
               if(num > 75.00){
               Console.WriteLine("Intervalo (75,100]");
                
               }else{
               Console.WriteLine("Intervalo [75,100]");
               
               }
           }
        }
    }
}
