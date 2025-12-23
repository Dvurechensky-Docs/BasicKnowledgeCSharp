/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 декабря 2025 10:47:17
 * Version: 1.0.126
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