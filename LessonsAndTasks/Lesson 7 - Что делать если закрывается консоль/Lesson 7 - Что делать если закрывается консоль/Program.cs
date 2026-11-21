/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 ноября 2026 12:02:25
 * Version: 1.0.461
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