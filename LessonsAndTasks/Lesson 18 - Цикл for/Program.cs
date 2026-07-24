/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 июля 2026 11:37:07
 * Version: 1.0.342
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