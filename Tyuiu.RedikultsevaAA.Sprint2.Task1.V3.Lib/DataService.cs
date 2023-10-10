using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

// Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении) и логических операций
// (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также арифметических выражений, которая вернет логическую последовательность(массив):
// (True, False, False, False, False, False), при a = 185, b = 316, c = 134, d = 134


namespace Tyuiu.RedikultsevaAA.Sprint2.Task1.V3.Lib
{
    public class DataService : ISprint2Task1V3
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b) | (c > d);
            res[1] = (a > b) & (c < d);
            res[2] = (a > b) || (c < d);
            res[3] = (a > b) && (c < d);
            res[4] = !res[0];
            res[5] = (a > b) ^ (c < d);

            return res;
        }
    }
}
