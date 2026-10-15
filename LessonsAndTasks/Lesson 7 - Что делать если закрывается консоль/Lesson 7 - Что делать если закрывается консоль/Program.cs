/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 октября 2026 07:43:02
 * Version: 1.0.424
 */

using System;

/*
 * Что делать если закрывается консоль?
 */
class Program
{
    static void Main()
    {
        Console.WriteLine("Консоль закрывается! =)");
        Console.ReadLine(); // Console.Read() || Console.ReadKey()
    }
}