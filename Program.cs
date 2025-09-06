using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double memory = 0;
            double cur = 0;
            Console.WriteLine("Калькулятор \nДоступные операции: +, -, *, /, %, 1/x, x^2, sqrt, M+, M-, MR, C, exit");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Текущее значение: " + cur);
                Console.WriteLine("Память: " + memory);
                Console.Write("Введите число или операцию: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    break;
                }
                if (input.ToLower() == "c")
                {
                    cur = 0;
                    Console.WriteLine("Значение сброшено");
                    continue;
                }
                if (input.ToLower() == "m+")
                {
                    memory += cur;
                    Console.WriteLine("Добавлено в память");
                    continue;
                }
                if (input.ToLower() == "m-")
                {
                    memory -= cur;
                    Console.WriteLine("Вычтено из памяти");
                    continue;
                }
                if (input.ToLower() == "mr")
                {
                    cur = memory;
                    Console.WriteLine("Восстановлено из памяти: " + memory);
                    continue;
                }
                if (input.ToLower() == "1/x")
                {
                    if (cur == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                    }
                    else
                    {
                        cur = 1 / cur;
                        Console.WriteLine("Результат: " + cur);
                    }
                    continue;
                }
                if (input.ToLower() == "x^2")
                {
                    cur = cur * cur;
                    Console.WriteLine("Результат: " + cur);
                    continue;
                }
                if (input.ToLower() == "sqrt")
                {
                    if (cur < 0)
                    {
                        Console.WriteLine("Ошибка: корень из отрицательного числа!");
                    }
                    else
                    {
                        cur = Math.Sqrt(cur);
                        Console.WriteLine("Результат: " + cur);
                    }
                    continue;
                }
                if (input == "+" || input == "-" || input == "*" || input == "/" || input == "%")
                {
                    Console.Write("Введите второе число: ");
                    string secondInput = Console.ReadLine();
                    try
                    {
                        double secondNum = Convert.ToDouble(secondInput);


                        switch (input)
                        {
                            case "+":
                                cur += secondNum;
                                break;
                            case "-":
                                cur -= secondNum;
                                break;
                            case "*":
                                cur *= secondNum;
                                break;
                            case "/":
                                if (secondNum == 0)
                                {
                                    Console.WriteLine("Ошибка: деление на ноль!");
                                }
                                else
                                {
                                    cur /= secondNum;
                                }
                                break;
                            case "%":
                                if (secondNum == 0)
                                {
                                    Console.WriteLine("Ошибка: деление на ноль при взятии остатка!");
                                }
                                else
                                {
                                    cur %= secondNum;
                                }
                                break;
                        }
                        Console.WriteLine("Результат: " + cur);
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка: введено не число!");
                    }
                    continue;
                }
                try
                {
                    double num = Convert.ToDouble(input);
                    cur = num;
                }
                catch
                {
                    Console.WriteLine("Неверный ввод! Введите число или команду.");
                }
            }
            Console.WriteLine("Калькулятор закрыт");
            Console.ReadKey();
        }
    }
}


