/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 октября 2026 11:01:04
 * Version: 1.0.423
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