using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RedikultsevaAA.Sprint2.Task7.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (x * x + y * y <= 1)
                if (y >= x)
                    return true;
                else if (x <= 0)
                    return true;
                else
                    return false;
            else
                return false;
        }
    }
}
