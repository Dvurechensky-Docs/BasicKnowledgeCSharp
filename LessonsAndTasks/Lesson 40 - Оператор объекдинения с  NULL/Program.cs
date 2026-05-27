/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 мая 2026 13:03:10
 * Version: 1.0.283
 */

using System;

/*
 * Оператора объединения с NULL ??
 */
class Program
{
    static void Main()
    {
        string str = null;
        Console.WriteLine(str ?? "NULL");
        Console.WriteLine("Lenght" + str ?? "no");
        Console.ReadKey();
    }
}