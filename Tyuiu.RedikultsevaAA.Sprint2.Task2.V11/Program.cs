using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RedikultsevaAA.Sprint2.Task2.V11.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint2.Task2.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                  *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющей структуры                                    *");
            Console.WriteLine("* Задание #2                                                                 *");
            Console.WriteLine("* Вариант #11                                                                *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и   *");
            Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области.  *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Введите значение переменной X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y:");
            int y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);
            if (res == true)
                Console.WriteLine("Точка находится в заштрихованной области");
            else
                Console.WriteLine("Точка не находится в заштрихованной области");

            Console.ReadKey();
        }
    }
}
