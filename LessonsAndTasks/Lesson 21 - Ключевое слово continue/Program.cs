/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 июня 2026 08:46:48
 * Version: 1.0.293
 */

using System;

/*
 * ключевое слово continue
 */
class Program
{
    static void Main()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i == 2)
                continue;
            Console.WriteLine(i);
        }
        Console.ReadKey();
    }
}