using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RedikultsevaAA.Sprint2.Task5.V11.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint2.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                  *");
            Console.WriteLine("* Тема: Оператор switch                                                      *");
            Console.WriteLine("* Задание #5                                                                 *");
            Console.WriteLine("* Вариант #11                                                                *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет требуемое *");
            Console.WriteLine("* значение и возвращает результат.                                           *");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется тремя натуральными числами:   *");
            Console.WriteLine("* g(год), m(порядковый номер месяца) и n(число). По заданным g, n и m        *");
            Console.WriteLine("* определить дату следующего дня. Заданный год не является високосным.       *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            string res;

            Console.WriteLine("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер месяца:");
            int m = Convert.ToInt32(Console.ReadLine());

            if (m > 12 || m < 1)
            {
                res = "Неверно введен номер месяца";

                Console.WriteLine("Введите день:");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n > 31 || n < 1)
                { 
                    res = "Неверно введен номер месяца и неверно введен день"; 
                }

            }

            else
            {
                Console.WriteLine("Введите день:");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n > 31 || n < 1)
                {
                    res = "Неверно введен номер месяца и неверно введен день";
                }
                else
                {
                    res = "Следующий день: " + ds.FindDateOfNextDay(g, m, n);
                }
            }




                Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
