/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 июля 2026 10:59:08
 * Version: 1.0.335
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