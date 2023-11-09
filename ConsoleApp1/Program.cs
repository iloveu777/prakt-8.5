using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Vvod(ref int x)
        {
            Write($"введите  число = ");
            x = int.Parse(ReadLine());
        }
        //метод для получения длины стороны
        static double CoordToSide(int x1,int y1, int x2, int y2)
        {
            double side = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return side;
        }
        //для получения периметра и площади
        static double P_and_S(double a, double b, double c)
        { 
        double p = a + b + c;
            Console.WriteLine("Периметр равен: " + p);
            double p2 = p / 2;
        double S = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return S;
        }
        static void Check(ref double a, ref double b,ref double c)
        {
            if (a < c + b && b < c + a && c < a + b)
            {

            }
            else
            {
                Clear();
                WriteLine("Ошибка!!!!!! Треугольник не существует!");
            
            }
        }
        static void Main(string[] args)
        {
            int x1=1,x2=2,x3=3,y1=4,y2=5,y3=6;
            Vvod(ref x1); Vvod(ref x2); Vvod(ref x3); Vvod(ref y1); Vvod(ref y2); Vvod(ref y3);
            double a = CoordToSide(x1,y1,x2,y2);
            double b = CoordToSide(x3, y3, x2, y2);
            double c = CoordToSide(x3, y3, x1, y1);
            Check(ref a,ref  b, ref c);
            WriteLine(P_and_S(a, b, c));

            ReadKey();
        }
    }
}
