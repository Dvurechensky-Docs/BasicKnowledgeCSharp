/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 сентября 2025 17:15:07
 * Version: 1.0.35
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