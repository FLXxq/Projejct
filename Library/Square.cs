using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Square
    {
        public static string methodSquare(double a, double b, double c)
        {
            double d = (b * b) - (4 * a * c);

            if (a == 0)
            {
                return "Первое слагаемое не может равняться 0";
            }
            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return $"Корень x1 ={x1} Корень x2 = {x2}";
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                return $"Корень x1 = {x}";
            }
            else
            {
                return "Корней нет";
            }
        }
    }
}
