/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 ноября 2026 11:58:11
 * Version: 1.0.468
 */

using System;

/*
 * Цикл for
 */
class Program
{
    private static int count;

    static void Main()
    {
        //Переменная count в счетчике существует только внутри цикла
        for (byte count = 0; count < 10; count++)
        {
            Console.WriteLine(count);
        }

        //Переменная count объявляется вне цикла и существует вне зависимости от положения цикла в коде
        while (count < 10)
        {
            count++;
            Console.WriteLine(count);
        }
        Console.ReadKey();
    }
}