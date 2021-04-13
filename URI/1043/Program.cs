using System;
using System.Globalization;

namespace _1043
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double A = double.Parse(input[0],CultureInfo.InvariantCulture);
            double B = double.Parse(input[1],CultureInfo.InvariantCulture);
            double C = double.Parse(input[2],CultureInfo.InvariantCulture);

            double[] nums= {A,B,C};
            Array.Sort(nums);
            
            bool triangule1 =nums[2]+nums[0]>=nums[1] && nums[2]-nums[0] <= nums[1] ;
            bool triangule2 =nums[1]+nums[0]>=nums[2] && nums[1]-nums[0] <=nums[2] ;
            bool triangule3 =nums[1]+nums[2]>=nums[0] && nums[1]-nums[2] <= nums[0] ;

            if(triangule1 && triangule2 && triangule3){
                //impossivel calcular triangulo entao faremos um trapezio
                double area =((A+B)*C)/2;
                Console.WriteLine("Area = "+area.ToString("F1",CultureInfo.InvariantCulture));
            }else{
                //Caso triangulo for possivel calcule seu perimetro
                double perimetro=A+B+C;
                Console.WriteLine("Perimetro = "+perimetro.ToString("F1",CultureInfo.InvariantCulture));
            }
        }
    }
}
