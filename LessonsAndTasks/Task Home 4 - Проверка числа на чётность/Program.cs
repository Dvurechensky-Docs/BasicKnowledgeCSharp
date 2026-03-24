/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 марта 2026 08:53:38
 * Version: 1.0.217
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