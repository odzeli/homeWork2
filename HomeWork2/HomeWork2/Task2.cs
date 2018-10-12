//Одзели
//2. Написать метод подсчета количества цифр числа.
using System;

namespace HomeWork2
{
    partial class Program
    {
        static void amountDigitOfNumber()
        {
            Console.Write("Введите число а мы подсчитаем кол-во цифр в нем: ");
            var number = Console.ReadLine();
            Console.WriteLine($"Кол-во цифр в числе: {number.Length}");
        }
    }
}
