/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 октября 2026 09:03:43
 * Version: 1.0.434
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