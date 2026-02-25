/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 февраля 2026 14:01:03
 * Version: 1.0.190
 */

using System;

/*
 *  ключевое слово break 
 */
class Program
{
    static void Main()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(i);

            string msg = Console.ReadLine();

            if (msg == "exit")
                break;
            else if (i == 10)
                break;
        }
        Console.ReadKey();
    }
}