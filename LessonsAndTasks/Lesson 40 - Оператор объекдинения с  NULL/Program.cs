/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 мая 2026 10:37:18
 * Version: 1.0.267
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