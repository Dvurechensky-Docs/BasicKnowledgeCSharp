/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 ноября 2025 06:51:29
 * Version: 1.0.99
 */

using System;

class Program
{
    static void Main()
    {
        int a;

        a = int.Parse(Console.ReadLine());

        if (a % 2 == 1)
        {
            Console.WriteLine("Не чётное");
        }
        else
        {
            Console.WriteLine("Чётное");
        }
        Console.ReadKey();
    }
}