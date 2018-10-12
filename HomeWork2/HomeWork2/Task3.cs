//Одзели
//3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
using System;

namespace HomeWork2
{
    partial class Program
    {
        static void enterDigitWhileZero()
        {
            int number;
            int sum = 0;
            Console.WriteLine("Вводите числа, мы остановим программу, когда вы введете 0: ");
            do
            {
                number = int.Parse(Console.ReadLine());
                if (number % 2 != 0)
                {
                    sum += number;
                }
                //numbers.Add(key);
            }
            while (number != 0);
            Console.WriteLine(sum);
        }
    }
}
