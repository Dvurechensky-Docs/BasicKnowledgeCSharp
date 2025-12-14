/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 декабря 2025 14:33:40
 * Version: 1.0.117
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