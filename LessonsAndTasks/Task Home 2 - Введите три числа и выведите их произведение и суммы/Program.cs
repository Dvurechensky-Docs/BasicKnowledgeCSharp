﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 сентября 2025 11:06:01
 * Version: 1.0.13
 */

using System;

/*
 * 2. Введите три числа и выведите на экран значение суммы и произведения этих чисел.
 */
class Program
{
    static void Main()
    {
        int firstValue, secondValue, thirdValue, res_sum, res_multy;

        Console.WriteLine("Введите число 1: ");

        int.TryParse(Console.ReadLine(), out firstValue);

        Console.WriteLine("Введите число 2: ");

        int.TryParse(Console.ReadLine(), out secondValue);

        Console.WriteLine("Введите число 3: ");

        int.TryParse(Console.ReadLine(), out thirdValue);

        res_sum = firstValue + secondValue + thirdValue;
        res_multy = firstValue * secondValue * thirdValue;

        Console.WriteLine("Результат суммы чисел: " + res_sum);
        Console.WriteLine("Результат умножения чисел: " + res_multy);
        Console.ReadKey();
    }
}