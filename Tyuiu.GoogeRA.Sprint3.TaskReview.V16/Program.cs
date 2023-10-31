
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoogeRA.Sprint3.TaskReview.V16.Lib;

namespace Tyuiu.GoogeRA.Sprint3.TaskReview.V16
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #3| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #3                                                  *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту    *");
            Console.WriteLine("* Задание #7                                                 *");
            Console.WriteLine("* Вариант #20                                                *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Написать программу котроя выводит таблицу значений функции *");
            Console.WriteLine("* F(x) на заданном диапозоне [-5;5]                          *");
            Console.WriteLine("* сумму всех делителей больше 8                             * ");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Начало отрезка " + startValue);
            Console.WriteLine("Конец отрезка " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] v;
            v = new double[len];
            v = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}    |  {1, 5:f2}", startValue, v[i]);
                startValue++;
            }

            Console.WriteLine("+----------+----------+");
            Console.ReadKey();

        }
    }
}
