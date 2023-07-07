using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looopka.FirstHWGB
{
    internal class Functions
    {
        public static double GetMax(double[] list)
        {
            double maxNum = list[0];
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > maxNum)
                    maxNum = list[i];
            }
            return maxNum;
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static void GetAllEven(int len)
        {
            for (int i = 1; i <= len; i++)
            {
                if (IsEven(i))
                    Console.WriteLine(i);
            }
        }
        public static int GetTask(string userInput)
        {
            switch (userInput)
            {
                case "get-max":
                    Console.WriteLine("Вы запустили поиск максимального из двух чисел");
                    Console.Write("Введите число A:");
                    string twoNumbers = Console.ReadLine();
                    Console.Write("Введите число B:");
                    twoNumbers += ',' + Console.ReadLine();
                    ParseTask("get-max", twoNumbers);
                    return 0;
                case "get-max-multi":
                    Console.WriteLine("Вы запустили поиск максимального из трех чисел");
                    Console.WriteLine("Введите числа через запятую");
                    string multiNumbers = Console.ReadLine();
                    ParseTask("get-max", multiNumbers);
                    return 0;
                case "is-even":
                    Console.WriteLine("Вы запустили проверку на четность");
                    Console.Write("Введи число:");
                    string evenNum = Console.ReadLine();
                    ParseTask("is-even", evenNum);
                    return 0;
                case "get-even":
                    Console.WriteLine("Вы запустили поиск четных чисел");
                    Console.Write("Введи ограничение сверху, до которого нужно найти все четные:");
                    string evenMulti = Console.ReadLine();
                    ParseTask("get-even", evenMulti);
                    return 0;
                case "quit":
                    Console.WriteLine("Работа программы закончена!");
                    return 1;
                default:
                    Console.WriteLine("команда не найдена");
                    PrintFunctions();
                    return 0;


            }
        }

        public static void PrintFunctions()
        {
            Console.WriteLine("get-max - поиск максимального из двух");
            Console.WriteLine("get-max-multi - поиск максимального из введеных чисел");
            Console.WriteLine("is-even - проверка числа на четность");
            Console.WriteLine("get-even - поиск всех четный чисел в указанном диапазоне");
            Console.WriteLine("quit - выход из программы");
        }

        public static void ParseTask(string task, string answer)
        {
            if (task == "get-max")
            {
                
                string[] answers = answer.Split(',');
                double[] numbers = new double[answers.Length];
                if (answers.Length <= 3)
                {
                    for (int i = 0; i < answers.Length; i++)
                    {
                        double.TryParse(answers[i], out numbers[i]);
                    }
                    Console.Write("Максимальное из введеных чисел:");
                    Console.WriteLine(GetMax(numbers));
                } else { Console.WriteLine("Задание введено не корректно"); }
            }
            else if (task == "is-even")
            {
                int.TryParse(answer, out int num);
                if (IsEven(num))
                    Console.WriteLine("Число четное");
                else
                    Console.WriteLine("Число не четное");

            }
            else if (task == "get-even")
            {
                int.TryParse(answer, out int num);
                GetAllEven(num);

            }
        }
    }
}
