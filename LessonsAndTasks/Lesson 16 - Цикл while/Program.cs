/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 июня 2026 06:51:11
 * Version: 1.0.295
 */

using System;

/*
 * Цикл while
 */
class Program
{
    static void Main()
    {
        int count = 0;
        int.TryParse(Console.ReadLine(), out int limit);
        while (count < limit)
        {
            count++;
            Console.WriteLine($"{count} Выполняем действия");
        }
        Console.ReadKey();
    }
}