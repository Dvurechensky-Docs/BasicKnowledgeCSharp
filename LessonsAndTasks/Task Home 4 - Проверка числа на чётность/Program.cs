/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 марта 2026 10:11:12
 * Version: 1.0.221
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