using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = Input("Введите первую координату первой вершины = ");
            int y1 = Input("Введите вторую координату первой вершины = ");

            int x2 = Input("Введите первую координату второй вершины = ");
            int y2 = Input("Введите вторую координату второй вершины = ");

            int x3 = Input("Введите первую координату третьей вершины = ");
            int y3 = Input("Введите вторую координату третьей вершины = ");

            int x4 = Input("Введите первую координату четвёртой вершины = ");
            int y4 = Input("Введите вторую координату четвёртой вершины = ");

            int x5 = Input("Введите первую координату пятой вершины = ");
            int y5 = Input("Введите вторую координату пятой вершины = ");

            double area1 = Area(x1, y1, x2, y2, x5, y5);
            double area2 = Area(x2, y2, x3, y3, x5, y5);
            double area3 = Area(x3, y3, x4, y4, x5, y5);

            double area = area1 + area2 + area3;

            Console.WriteLine($"Площадь пятиугольника = {area}");
            Console.ReadKey();
        }
        static double Area(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            return 0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        }
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
    }
}
