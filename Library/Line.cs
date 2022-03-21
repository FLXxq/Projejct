using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   public class Line
    {
        //Вычесление линейного уравнения
        // <parm name = "k"> первый </parm>
        // <parm name = "m"> второй </parm>
        // <return> результат вычесления </return>
        public static string MethodLine(double  k, double n)
        {
            if (k == 0 && n == 0)
            {
                return "Ответ R, т.к есть совпадения прямой с осью";
            }
            else if (k == 0)
            {
                return "Решений нет";
            }
            else
            {
                var x = -n / k;
                return $"Ответ {x}";
            }

        }
    }
}
