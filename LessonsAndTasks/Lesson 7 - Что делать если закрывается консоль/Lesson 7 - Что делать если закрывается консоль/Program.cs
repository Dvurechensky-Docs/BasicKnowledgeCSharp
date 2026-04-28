/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 апреля 2026 14:24:38
 * Version: 1.0.253
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