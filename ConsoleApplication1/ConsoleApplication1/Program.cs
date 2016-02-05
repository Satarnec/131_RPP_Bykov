using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {//пункты 1-4, объявление переменных, ввод значеный, инициализация суммы, вывод значения на экран
            int x = 13; 
            int y = 7;
            int z = x + y;
            Console.WriteLine(z);
            //Вывод положительного или отрицательного числа
            if (z > 0)
            {
                Console.WriteLine("Больше нуля");
            }
            else
            {
                Console.WriteLine("Меньше нуля");
            }
            //Четность или не четность значения
           if (z % 2 == 0)
            {
                Console.WriteLine("Четное");
            }
            else
            {
                Console.WriteLine("Не четное");
            }
            //проверка делимости на 5
            if (z % 5 == 0)
            {
               Console.WriteLine("Делится на 5");
            }
            else
            {
               Console.WriteLine("Не делится на 5");
            }
            //проверка делимости на 10
            if (z % 10 == 0)
            {
                Console.WriteLine("Делится на 10");
            }
            else
            {
                Console.WriteLine("Не делится на 10");
            }
            //проверка делимости на 20
             if (z % 20 == 0)
            {
                Console.WriteLine("Делится на 20");
            }
            else
            {
                Console.WriteLine("Не делится на 20");
            }
             Console.ReadKey(); 
          }
        }
    }

