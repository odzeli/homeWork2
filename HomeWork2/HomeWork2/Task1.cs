using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    partial class Task1
    {
        private static void minimalNumber()
        {
            int[] numbers = new int[3];
            int minimalNumber = 0;
            Console.Write("Введите 1-е число: ");
            numbers[0] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.Write("Введите 2-е число: ");
            numbers[1] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.Write("Введите 3-е число: ");
            numbers[2] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            minimalNumber = numbers[1];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i + 1 < numbers.Length)
                {
                    if (numbers[i] < numbers[i + 1] && numbers[i] < minimalNumber)
                    {
                        minimalNumber = numbers[i];
                    }
                }
                else
                {
                    if (numbers[i] < minimalNumber)
                    {
                        minimalNumber = numbers[i];
                    }
                }
            }
            Console.WriteLine($"Из данной последовательности меньшее число: {minimalNumber}");
        }
    }
}
