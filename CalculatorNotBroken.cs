using System;

namespace CalculatorNotBroken
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
				result = Add(num1, num2); // Исправлено: Multiiply на Multiply
			else if (operation == "-")
				result = Subtract(num1, num2); // Исправлено: Subtractt на Subtract
			else if (operation == "*")
				result = Multiply(num1, num2); // Исправлено: Multiiply на Multiply
			else if (operation == "/") // Исправлено: "*" на "/"
				result = Divide(num1, num2); // Исправлено: добавлена точка с запятой
			else
				Console.WriteLine("Неизвестная операция!");

			Console.WriteLine($"Результат: {result}");
		}

		static double Add(double a, double b) // Исправлено: русская А на английскую 
		{
			return a + b; // Исправлено: убрано лишнее "+ a + b"
		}

		static double Subtract(double a, double b) // Исправлено: Subtractt на Subtract
		{
			return a - b; // Исправлено: "bb" на "b"
		}

		static double Multiply(double a, double b) // Исправлено: Multiplyy на Multiply
		{
			return a * b; // Исправлено: "**" на "*"
		}

		static double Divide(double a, double b) // Исправлено: bool на double
		{
			if (b == 0) // Исправлено: "=" на "=="
			{
				Console.WriteLine("Ошибка: деление на ноль!");
				return 0;
			}
			return a / b;
		}
	}
}