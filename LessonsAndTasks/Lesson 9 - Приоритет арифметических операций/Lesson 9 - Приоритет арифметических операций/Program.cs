/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 июня 2026 08:46:48
 * Version: 1.0.293
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