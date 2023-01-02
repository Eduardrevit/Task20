using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            
            MyDelegate myDelegate = Circumference;
            myDelegate += AreaCircle;
            myDelegate += BallVolume;
            Console.WriteLine("Введите значение радиуса");
            double r = Convert.ToDouble(Console.ReadLine());
            myDelegate(r);
            Console.ReadKey();
        }

        static double Circumference(double r)
        {
            double l = 2 * r * Math.PI;
            Console.WriteLine($"Длина окружности равна {l:F2}");
            return l;
        }
        static double AreaCircle(double r)
        {
            double s = Math.Pow(r, 2) * Math.PI;
            Console.WriteLine($"Площадь круга равна {s:F2}");
            return s;
        }
        static double BallVolume(double r)
        {
            double v = Math.Pow(r, 3) * Math.PI * 4 / 3;
            Console.WriteLine($"Объем шара равен {v:F2}");
            return v;
        }
    }
}
