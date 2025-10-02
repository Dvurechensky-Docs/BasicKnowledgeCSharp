/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 октября 2025 06:51:36
 * Version: 1.0.44
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