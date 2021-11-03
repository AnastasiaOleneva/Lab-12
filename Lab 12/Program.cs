using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle.Radius = 3;
            Circle.X = 3;
            Circle.Y = 5;
            Console.WriteLine(Circle.Area_circle());
            Console.WriteLine(Circle.Lenght_circle());
            Console.WriteLine(Circle.CirclePoint());
            Console.ReadKey();
        }
    }

    static class Circle
    {
        const double PI = 3.14;

        public static int X { get; set; }
        public static int Y { get; set; }


        public static double Radius { get; set; }

        static Circle()
        {
            double radius = Radius;
            int x = X;
            int y = Y;

        }
        public static double Lenght_circle()
        {

            double L = 2 * PI * Radius;

            Console.WriteLine("Длина окружности равна {0}", L);
            return L;

        }

        public static double Area_circle()
        {

            double A = PI * Math.Pow(Radius, 2);

            Console.WriteLine("Площадь круга равна {0}", A);
            return A;

        }

        public static bool CirclePoint()
        {

            double R = Math.Sqrt(Math.Pow(X - 0, 2) + Math.Pow(Y - 0, 2));

            if (Radius <= R)
            {
                Console.WriteLine("Точка не принадлежит кругу");
            }
            else
            {
                Console.WriteLine("Точка принадлежит кругу");


            }
            return true;

        }


    }   }       