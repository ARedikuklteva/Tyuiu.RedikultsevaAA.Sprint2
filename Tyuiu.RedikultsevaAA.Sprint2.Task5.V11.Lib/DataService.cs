using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

// Написать программу, которая использует оператор switch вычисляет требуемое значение и возвращает результат.
// Условие: Дата некоторого дня характеризуется тремя натуральными числами: g(год), m(порядковый номер месяца)
// и n(число). По заданным g, n и m определить дату следующего дня. Заданный год не является високосным.

namespace Tyuiu.RedikultsevaAA.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int g1 = 0;
            int m1 = 0;
            int n1 = 0;

            switch (m)
            {
                case 1:
                    switch (n)
                    {
                        case 31:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 2:
                    switch (n)
                    {
                        case 28:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 3:
                    switch (n)
                    {
                        case 31:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 4:
                    switch (n)
                    {
                        case 30:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 5:
                    switch (n)
                    {
                        case 31:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 6:
                    switch (n)
                    {
                        case 30:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 7:
                    switch (n)
                    {
                        case 31:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 8:
                    switch (n)
                    {
                        case 31:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 9:
                    switch (n)
                    {
                        case 30:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 10:
                    switch (n)
                    {
                        case 31:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 11:
                    switch (n)
                    {
                        case 30:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 12:
                    switch (n)
                    {
                        case 31:
                            g1 = g + 1;
                            m1 = 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;
            }
            return Convert.ToString(n1) + "." + Convert.ToString(m1) + "." + Convert.ToString(g1);
        }
    }
}
