/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 ноября 2026 07:44:39
 * Version: 1.0.459
 */

using System;

/*
 * Цикл do while
 * Всегда выполняется один раз 
 * даже если условие цикла не выполянется
 */
class Program
{
    static void Main()
    {
        int count = 5;
        while (count < 5)
        {
            count++;
            Console.WriteLine($"{count} Действие");
        }
        do
        {
            count++;
            Console.WriteLine($"{count} Действие");
        } while (count < 5);
        Console.ReadKey();
    }
}