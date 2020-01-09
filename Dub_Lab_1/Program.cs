using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Лабораторная работа №1
            //Разработать программу для решения биквадратного уравнения.
            //+ 1.Программа должна быть разработана в виде консольного приложения на языке C#.
            //+ 2.Программа должна позволять осуществлять ввод с клавиатуры коэффициентов А, В, С,  
            //  (уметь реализовывать ввод коэффициентов через параметры командной строки)
            //+ 3.Программа должна вычислять дискриминант и корни уравнения(в зависимости от дискриминанта). 
            //     В зависимости от введенных значений коэффициентов А, В, С, 
            //     в программе должны быть реализованы варианты решений при А = 0, В = 0
            //+ 4.Если хотя бы один из коэффициентов А, В, С введен некорректно, то программа должна сообщить об ошибке(цвет шрифта красный и позволить и ввести коэффициент повторно.
            //+ 5.отображать на экране информацию зеленым цветом(если корни имеются) и красным, если корней нет
            //+ 6.Выводить в заголовке окна фамилию имя и номер группы

            Console.WriteLine("Лабораторная работа №1");
            Console.Title = "Дубянский А. И., ИУ5Ц-51Б";

            //Вывод параметров командной строки

            double a, b, c, d, t1, t2, t;
            // double num1;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Поиск корней биквадратного уровнения");
            Console.ForegroundColor = ConsoleColor.Gray;

            //if (double.TryParse(Console.ReadLine(), out num1))
            //{
            a = ReadDouble("Введите коэффициент A: ");
            b = ReadDouble("Введите коэффициент B: ");
            c = ReadDouble("Введите коэффициент C: ");
            Console.ReadLine();
            //   break;
            Console.WriteLine(" Ваше уравнение: ");
            Console.WriteLine(a + "x^4 +" + b + "x^2 +" + c + " = 0");
            Console.ReadLine();


            if (a == 0 && b == 0 && c != 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Это не уравнение!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(" Заменим x^2 на t и получим:");
                Console.WriteLine(a + "t^2 +" + b + "t " + c + " = 0");
                Console.WriteLine("\n Найдем корни t1, t2!");

                d = (b * b) - (4 * a * c);

                Console.WriteLine(" Дескриминант =  " + d);
                Console.WriteLine("Корень из дескрименанта =  " + Math.Sqrt(d));

                if (d > 0)
                {
                    Console.WriteLine("\n Уравнение имеет 2 корня!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    t1 = ((-b) - (Math.Sqrt(d))) / (2 * a);
                    Console.WriteLine("t1 = " + t1);
                    t2 = ((-b) + (Math.Sqrt(d))) / (2 * a);
                    Console.WriteLine("t2 = " + t2);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadKey();

                    if (t1 >= 0 && t2 >= 0)
                    {
                        Console.WriteLine("\n Теперь возведем переменные t1 и t2 в корни и получим: ");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x1 = " + Math.Sqrt(t1));
                        Console.WriteLine("x2 = " + -Math.Sqrt(t1));
                        Console.WriteLine("x3 = " + Math.Sqrt(t2));
                        Console.WriteLine("x4 = " + -Math.Sqrt(t2));
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();
                    }
                    else if (t1 >= 0 && t2 < 0)
                    {
                        Console.WriteLine("\n Теперь проведем обратную замену положительной переменной t1: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x1 = " + Math.Sqrt(t1));
                        Console.WriteLine("x2 = " + -Math.Sqrt(t1));
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Нет корней от t2!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();
                    }
                    else if (t1 < 0 && t2 >= 0)
                    {
                        Console.WriteLine("\n Теперь проведем обратную замену положительной переменной t2: ");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Нет корней от t1!");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x1 = " + Math.Sqrt(t2));
                        Console.WriteLine("x2 = " + -Math.Sqrt(t2));
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();
                    }
                    else if (t1 < 0 && t2 < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Нет корней от t1 и t2!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();
                    }
                }
                else if (d == 0)
                {
                    Console.WriteLine("\n Уравнение имеет только 1 корень!");
                    t = (-b) / (2 * a);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("t = " + t);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadKey();


                    Console.WriteLine("\n Теперь возведем переменную t в корень и получим: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("x1 = " + Math.Sqrt(t));
                    Console.WriteLine("x2 = " + -Math.Sqrt(t));
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadKey();

                }
                else if (d < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Уравнение не имеет корней или же имеет мнимые корни!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadKey();
                }
            }
            //}
            //else
            //{
            //   //Возвращаемся обратно
            //}
            //}
        }

        //CommandLineArgs(args); слова через пробел

        //static void CommandLineArgs(string[] args) слова через пробел
        //{
        //    /*
        //    Необходимо установить параметры командной строки (несколько слов
        //   через пробел)
        //    в пункте меню "Project", "название проекта Properties"
        //    вкладка "Debug", поле ввода "Command Line Arguments"
        //    */
        //    //Вывод параметров командной строки 1
        //    Console.WriteLine("\nВывод параметров командной строки 1:");
        //    for (int i = 0; i < args.Length; i++)
        //    {
        //        Console.WriteLine("Параметр [{0}] = {1}", i, args[i]);
        //    }

        //}
        static double ReadDouble(string message)
        {
            string resultString;
            double resultDouble;
            bool flag;
            do
            {
                Console.Write(message);
                resultString = Console.ReadLine();
                //Первый способ преобразования строки в число
                flag = double.TryParse(resultString, out resultDouble);

                if (!flag)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Необходимо ввести вещественное число");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            while (!flag);
            return resultDouble;
        }
    }
}

