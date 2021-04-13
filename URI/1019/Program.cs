using System;

namespace _1019
{
    class Program
    {
        static void Main(string[] args)
        {
        int time =int.Parse(Console.ReadLine());

        int hour = (time/3600);
        int minutes= (time%3600)/60;
        int seconds =((time%3600)%60)%60;

        Console.WriteLine(hour+":"+minutes+":"+seconds);
        }
    }
}
