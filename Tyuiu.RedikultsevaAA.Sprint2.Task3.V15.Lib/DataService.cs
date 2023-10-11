using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Написать программу, которая вычисляет требуемое значение функции Y с использованием вложенных оператор if-else,
// где пользователь вводит значение переменной X с клавиатуры. Округлить полученное значение до трех знаков после запятой
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RedikultsevaAA.Sprint2.Task3.V15.Lib
{
    public class DataService : ISprint2Task3V15
    {
        public double Calculate(double x)
        {
            double res;

            if (x > 1)
                res = x + Math.Pow(((x + 1) / (x - 1)), x);
            else if (x == 0)
                res = (x * x - Math.Cos(x) + 10) / (x * x - Math.Sin(0) + 12);
            else if ((x < 2) && (x > -19))
                res = Math.Pow(1 + 1 / (x*x), 8);
            else
                res = x + 10 * x - (1 / x);

            return Math.Round(res, 3);
        }
    }
}
