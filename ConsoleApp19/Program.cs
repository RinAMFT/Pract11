using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Input("Введите первое число = ");
            int b = Input("Введите втрое число = ");
            int c = Input("Введите третье число = ");
            int d = Input("Введите четвертое число = ");
            int e = Input("Введите пятое число = ");
            int f = Input("Введите шестое число = ");
            int g = Input("Введите седьмое число = ");
            int h = Input("Введите восьмое число = ");

            Console.WriteLine($"Максимально число = {Max(a, b, c, d, e, f, g, h)}");
            Console.ReadKey();
        }
        static int Max(int a, int b, int c, int d, int e, int f, int g, int h)
        {
            return Math.Max(a, Math.Max(b, Math.Max(c, Math.Max(d, Math.Max(e, Math.Max(f, Math.Max(g, h)))))));
        }
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }


    }
}
