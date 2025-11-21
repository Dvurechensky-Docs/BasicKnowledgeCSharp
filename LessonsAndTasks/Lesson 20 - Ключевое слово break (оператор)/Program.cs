/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 ноября 2025 09:30:35
 * Version: 1.0.94
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