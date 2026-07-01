/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 июля 2026 08:34:46
 * Version: 1.0.318
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