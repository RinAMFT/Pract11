using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
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

            double side1 = Distance(x1, y1, x2, y2);
            double side2 = Distance(x2, y2, x3, y3);
            double side3 = Distance(x3, y3, x1, y1);

            double perimeter = side1 + side2 + side3;

            Console.WriteLine($"Периметр треугольника = {perimeter:F2}");
            Console.ReadKey();
        }
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
