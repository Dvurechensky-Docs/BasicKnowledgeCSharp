﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:07:24
 * Version: 1.0.9
 */

using System;

/*
 * Инкремент и декремент. Постфиксный и префиксный.
 */
class Program
{
    static void Main()
    {
        int a = 0;
        int b = 1;

        a++; // Постфиксная - Сначала выведется переменная до инкремента а потом после него
        --a; // Префиксная - Сначала сработает увеличение переменной а результат выведется в консоль
        a--;
        a--;

        b = ++b * b;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.ReadKey();
    }
}