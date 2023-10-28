using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static double Raznosti(double a, double b)
        {
            return a - b;
        }
        static double Proizv(double a, double b)
        {
            return a * b;
        }
        static double Del(double a, double b)
        {
            return a / b;
        }
        static double Vosved(double a)
        {
            return a * a;
        }
        static double Izvlech(double a)
        {
            return Math.Sqrt(a);
        }
        static double Procent(double a, double b)
        {
            return (a * b) / 100;
        }
        static double Log(double a)
        {
            return Math.Log(a);
        }
        static double Sin(double a)
        {
            return Math.Sin(a);
        }
        static double Ctg(double a)
        {
            return Math.Cos(a) / Math.Sin(a);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите операцию:\n" +
                "1. Сложение\n" +
                "2. Вычитание\n" +
                "3. Произведение\n" +
                "4. Деление\n" +
                "5. Возведение в степень\n" +
                "6. Извлечение корня\n" +
                "7. Процент от числа\n" +
                "8. Log\n" +
                "9. Sin\n" +
                "10. Ctg\n");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Ответ: " + Sum(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                    break;
                case 2:
                    Console.WriteLine("Ответ: " + Raznosti(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                    break;
                case 3:
                    Console.WriteLine("Ответ: " + Proizv(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                    break;
                case 4:
                    Console.WriteLine("Ответ: " + Del(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                    break;
                case 5:
                    Console.WriteLine("Ответ: " + Vosved(Convert.ToDouble(Console.ReadLine())));
                    break;
                case 6:
                    Console.WriteLine("Ответ: " + Izvlech(Convert.ToDouble(Console.ReadLine())));
                    break;
                case 7:
                    Console.WriteLine("Ответ: " + Procent(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                    break;
                case 8:
                    Console.WriteLine("Ответ: " + Log(Convert.ToDouble(Console.ReadLine())));
                    break;
                case 9:
                    Console.WriteLine("Ответ: " + Sin(Convert.ToDouble(Console.ReadLine())));
                    break;
                case 10:
                    Console.WriteLine("Ответ: " + Ctg(Convert.ToDouble(Console.ReadLine())));
                    break;
                default:
                    Console.WriteLine("Такой операции не существует");
                    break;

            }
            Console.ReadKey();
        }
    }
}
