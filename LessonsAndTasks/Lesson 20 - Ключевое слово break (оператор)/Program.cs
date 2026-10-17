/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 октября 2026 07:37:10
 * Version: 1.0.426
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