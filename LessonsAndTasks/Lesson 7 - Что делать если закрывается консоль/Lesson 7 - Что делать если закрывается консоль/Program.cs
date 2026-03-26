/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 марта 2026 10:04:15
 * Version: 1.0.219
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