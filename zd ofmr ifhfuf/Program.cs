using System;

namespace zd_ofmr_ifhfuf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите катет");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите гипотенузу");
            double z = double.Parse(Console.ReadLine());
            double cat = Math.Sqrt(Math.Pow(x, 2) - Math.Pow(z, 2));
            double S = (1 / 2) * x * cat;
            
            Console.WriteLine("Катет1 ={0:F2}", x);      
            Console.WriteLine("Катет2={0:F2}", cat); 
            Console.WriteLine("Гипотенуза ={0:F2}", z);
            Console.WriteLine("Площадь треугольника ={0:F2}", S);
        }
    }
}
