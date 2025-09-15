﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 сентября 2025 06:51:33
 * Version: 1.0.27
 */

using System;

/*
 * Сумма чётных и нечётных чисел в диапазоне 
 */

namespace Task_Home_6___Сумма_чётных_и_нечётных_чисел_в_диапазоне
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());

            int count = 0, num_even = 0, num_odd = 0;

            //чётные
            double num_even_progressia = 0;
            double num_odd_progressia = 0;
            num_even_progressia = (1 + (num / 2)) * num / 2;
            num_odd_progressia = (0.5 + ((double)(num - 1) / 2)) * num / 2;
            Console.WriteLine($"Чётных прогрессия - {num_even_progressia}, Нечётных прогрессия - {num_odd_progressia}");

            while(count < num)
            {
                count++;
                if (count % 2 != 1) //Чётное
                    num_even += count;
                else
                    num_odd += count;
            }
            Console.WriteLine($"Чётных - {num_even}, Нечётных - {num_odd}");

            Console.ReadLine();
        }
    }
}
