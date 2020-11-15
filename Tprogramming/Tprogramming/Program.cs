using System;
using System.Collections.Generic;
using System.Text;

namespace Tprogramming
{
    public class Program
    {
        //Функция
        public static double Function(double a, double b, double x)
        {
            double a2 = Math.Pow(a, 2);
            double b2 = Math.Pow(b, 2);
            double x2 = Math.Pow(x, 2);
            double y = Math.Log(b2 - x2, a) / Math.Pow(Math.Abs(x2 - a2), 1/3);
            return y;
        }

        //Задача A
        public static void TaskA()
        {
            //Исходные данные
            double a = 2;
            double b = 4.1;
            double xH = 0.77;
            double xK = 1.77;
            double dx = 0.2;

            //Ответ
            double[] result = TaskA_Calculate(a, b, xH, xK, dx);

            //Вывод в консоль
            Console.WriteLine("Задача A:");
            foreach (double d in result)
            {
                Console.WriteLine(d);
            }
        }
        public static double[] TaskA_Calculate(double a, double b, double xH, double xK, double dx)
        {
            List<double> lst = new List<double>();
            for (double x = xH; x <= xK; x += dx)
            {
                lst.Add(Function(a, b, x));
            }
            return lst.ToArray();
        }

        //Задача B
        public static void TaskB()
        {
            //Исходные данные
            double a = 2;
            double b = 4.1;
            double[] xArray = new double[]
            {
                1.24,
                1.38,
                2.38,
                3.21,
                0.68
            };

            //Ответ
            double[] result = TaskB_Calculate(a, b, xArray);

            //Вывод в консоль
            Console.WriteLine("Задача B:");
            foreach (double d in result)
            {
                Console.WriteLine(d);
            }
        }
        public static double[] TaskB_Calculate(double a, double b, double[] xArray)
        {
            List<double> lst = new List<double>();
            foreach (double x in xArray)
            {
                lst.Add(Function(a, b, x));
            }
            return lst.ToArray();
        }

        //Основной метод
        static void Main(string[] args)
        {
            TaskA();
            Console.ReadKey();
            Console.Clear();
            TaskB();
            Console.ReadKey();
        }
    }
}
