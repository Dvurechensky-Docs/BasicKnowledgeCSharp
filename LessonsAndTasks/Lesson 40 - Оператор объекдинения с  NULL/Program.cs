/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 сентября 2026 09:34:04
 * Version: 1.0.405
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