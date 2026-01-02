/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 января 2026 11:05:30
 * Version: 1.0.136
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