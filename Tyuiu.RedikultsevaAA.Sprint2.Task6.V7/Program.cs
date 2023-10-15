using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RedikultsevaAA.Sprint2.Task6.V7.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint2.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                  *");
            Console.WriteLine("* Тема: Получение результата из switch                                       *");
            Console.WriteLine("* Задание #6                                                                 *");
            Console.WriteLine("* Вариант #7                                                                 *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора  *");
            Console.WriteLine("* switch вычисляет требуемое значение и возвращает результат.                *");
            Console.WriteLine("* Условие: С начала 1990 года по некоторый день прошло n месяцев и 2 дня.    *");
            Console.WriteLine("* Определить название месяца(январь, февраль и т.п.) этого дня.              *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            string res;

            Console.WriteLine("Год: 1990");
            int g = 1990;

            Console.WriteLine("Введите номер месяца:");
            int m = Convert.ToInt32(Console.ReadLine());

            if (m > 12 || m < 1)
                res = "Неверно введен номер месяца";

            else
                res = "Название месяца: " + ds.FindMonthName(g, m);


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
