﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RedikultsevaAA.Sprint2.Task1.V3.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint2.Task1.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                  *");
            Console.WriteLine("* Тема: Логические операции                                                  *");
            Console.WriteLine("* Задание #1                                                                 *");
            Console.WriteLine("* Вариант #3                                                                 *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,            *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в выражении) *");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность операций не  *");
            Console.WriteLine("* должна нарушаться), а также арифметических выражений, которая вернет       *");
            Console.WriteLine("* логическую последовательность(массив):                                     *");
            Console.WriteLine("* (True, False, False, False, False, False),                                 *");
            Console.WriteLine("* при a = 185, b = 316, c = 134, d = 134                                     *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int a = 185;
            int b = 316;
            int c = 134;
            int d = 134;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
