/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 декабря 2025 15:24:47
 * Version: 1.0.120
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