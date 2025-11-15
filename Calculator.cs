using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Простой калькулятор (+, -, *, /)");

            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите операцию (+, -, *, /): ");
            string operation = Console.ReadLine();

            double result = 0;

            if (operation == "+")
                result = Add(num1, num2);
            else if (operation == "-")
                result = Subtract(num1, num2);
            else if (operation == "*")
                result = Multiply(num1, num2);
            else if (operation == "/")
                result = Divide(num1, num2);
            else
                Console.WriteLine("Неизвестная операция!");

            Console.WriteLine($"Результат: {result}");
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return 0;
            }
            return a / b;
        }
    }
}