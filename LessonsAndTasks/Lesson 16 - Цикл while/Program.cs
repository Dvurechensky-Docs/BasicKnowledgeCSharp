/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 июля 2026 08:46:25
 * Version: 1.0.322
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