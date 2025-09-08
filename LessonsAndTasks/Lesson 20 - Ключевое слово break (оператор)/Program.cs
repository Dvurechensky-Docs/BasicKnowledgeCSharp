/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 сентября 2025 13:11:51
 * Version: 1.0.20
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