//Odzeli
//5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
//б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

using System;


namespace HomeWork2
{
    partial class Program
    {
        static void health()
        {
            int normBmi = 19;
            Console.Write("Ваш вес в кг.: ");
            int weight = int.Parse(Console.ReadLine());
            Console.Write("Ваш рост в см.: ");
            int growth = int.Parse(Console.ReadLine());
            double growthInMetres = growth / 100.00;
            var bmi = weight / (growthInMetres * growthInMetres);

            if (bmi < 18.5)
            {
                double inaccurancy = normBmi - bmi;
                double needWeightToGet = inaccurancy * (growthInMetres * growthInMetres);
                Console.WriteLine($"Недостаточная масса тела. Вам не хватает: {needWeightToGet}кг.");
                return;
            }
            if (bmi > 25)
            {
                double inaccurancy = bmi - normBmi;
                double needWeightToGet = inaccurancy * (growthInMetres * growthInMetres);
                Console.WriteLine($"Избыточная масса тела. Лишнего веса: {needWeightToGet}кг.");
                Console.WriteLine("Избыточная масса тела.");
                return;
            }
            Console.WriteLine("Ваш вес в пределах нормы.");
        }
    }
}
