/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 апреля 2026 14:24:38
 * Version: 1.0.253
 */

using System;

/*
 * Приоритет арифметических операций
 */
class Program
{
    static void Main()
    {
        int result = 2 + 2 * 2;
        int result1 = (2 + 2) * 2; // как и в математике обозначается "(" ")"

        Console.WriteLine(result);
        Console.WriteLine(result1);
        Console.ReadKey();
    }
}