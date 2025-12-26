/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 декабря 2025 13:31:17
 * Version: 1.0.129
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