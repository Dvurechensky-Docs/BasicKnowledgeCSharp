/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 января 2026 06:51:37
 * Version: 1.0.165
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