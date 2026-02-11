/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 февраля 2026 09:13:52
 * Version: 1.0.176
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