/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 апреля 2026 13:38:27
 * Version: 1.0.235
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