/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 декабря 2025 13:06:38
 * Version: 1.0.111
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