using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

// Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) и
// арифметических выражений, которая вернет логическую последовательность(массив): (True, False, True, False, True, False),
// при x = 1095, y = 475

namespace Tyuiu.RedikultsevaAA.Sprint2.Task0.V12.Lib
{
    public class DataService : ISprint2Task0V12
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y + 620;
            res[1] = x - 620 != y;
            res[2] = x - 621 < y;
            res[3] = x - 621 > y;
            res[4] = x - 620 <= y;
            res[5] = x - 622 >= y;

            return res;
        }
    }
}
