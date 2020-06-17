using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.DZ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Начальный уровень. Задание №11
             */
            Console.WriteLine("Архитектор Исаакиевского собора:");
            Console.WriteLine("1.Доменико Трезини");
            Console.WriteLine("2.Огюст Монферран");
            Console.WriteLine("3.Карл Росси");


            int input = int.Parse(Console.ReadLine());


            switch (input)
            {
                case 1:
                    {
                        Console.WriteLine("Неправильный ответ! Архитектор Исаакиевского собора — Огюст Монферран.");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Правильный ответ! Молодец!");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Неправильный ответ! Архитектор Исаакиевского собора — Огюст Монферран.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка ввода данных");
                        break;
                    }
            }
            Console.ReadKey();
            Console.Clear();

            /*
            Начальный уровень. Задание №20
            */

            Console.WriteLine("Введите номер месяца (число от 1 до 12):");

            int input1 = int.Parse(Console.ReadLine());

            switch (input1)
            {
                case 1:
                    {
                        Console.WriteLine("Зима");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Зима");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Весна");
                        break;

                    }
                case 4:
                    {
                        Console.WriteLine("Весна");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Весна");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Лето");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Лето");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Лето");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Осень");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Осень");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("Осень");
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("Зима");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка ввода данных");
                        break;
                    }
            }
            Console.ReadKey();
            Console.Clear();

            /*
            Начальный уровень. Задание №21
            */

            Console.WriteLine("Введите номер дня недели (число от 1 до 7):");

            int input2 = int.Parse(Console.ReadLine());

            switch (input2)
            {
                case 1:
                    {
                        Console.WriteLine("Это рабочий день");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Это рабочий день");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Это рабочий день");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Это рабочий день");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Это рабочий день");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Это выходной день. Суббота");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Это выходной день. Воскресенье");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Ошибка ввода данных");
                        break;
                    }
            }

            Console.ReadKey();
            Console.Clear();

            /*
            Начальный уровень. Задание №10
            */

            Console.WriteLine("В каком году началась вторая мировая война?");

            string inputA = Console.ReadLine();
            int a = int.Parse(inputA);
            int b = 1939;

            if (a == b)
            {
                Console.WriteLine("Правильно");
            }
            else
            {
                Console.WriteLine("Неправильно");
            }
        }
    }
}
       