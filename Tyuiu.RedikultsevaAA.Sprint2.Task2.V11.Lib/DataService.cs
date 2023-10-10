using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RedikultsevaAA.Sprint2.Task2.V11.Lib
{
    public class DataService : ISprint2Task2V11
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            if ((x <= 5) && (x >= 3) && (y >= 4) && (y <= 3))
                res = true;
            if ((x >= 5) && (x <= 10) && (y >= 6) && (y <= 9))
                res = true;
            if ((x >= 11) && (x <= 12) && (x <= 11) && (y >= 5))
                res = true;
            if ((x == 10) && (y >= 10) && (y <= 8))
                res = true;
            if ((x == 13) && (y == 8))
                res = true;
            if ((x == 7) && (y == 12))
                res = true;
            if ((x >= 3) && (x <= 7) && (y == 11))
                res = true;
            if ((x == 9) && (y >= 4) && (y <= 3))
                res = true;
            if ((x == 7) && (y >= 2) && (y <= 5))
                res = true;

            return res;

        }
    }
}
