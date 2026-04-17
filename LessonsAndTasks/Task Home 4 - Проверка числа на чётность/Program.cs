/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 апреля 2026 06:50:57
 * Version: 1.0.241
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