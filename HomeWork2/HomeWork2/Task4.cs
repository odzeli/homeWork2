//Одзели
//4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
//С помощью цикла do while ограничить ввод пароля тремя попытками.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    partial class Program
    {
        static void checkLogin()
        {
            string userName = "archil";
            string password = "123";
            int i = 0;
            while (i < 3)
            {
                ++i;
                var trying = 3 - i;
                Console.Write("Введите логин: ");
                string enterUserName = Console.ReadLine();
                if (userName.Equals(enterUserName))
                {
                    Console.Write("Введите пароль: ");
                    string enterPassword = Console.ReadLine();
                    if (password.Equals(enterPassword))
                    {
                        Console.WriteLine("Вы успешно прошли авторизацию.");
                        return;
                    }
                }
                if(trying != 0)
                {
                Console.WriteLine($"Попыток входа осталось: {trying}");
                }else
                {
                    Console.WriteLine("У вас не осталось попыток.");
                }
            }
        }
    }
}
