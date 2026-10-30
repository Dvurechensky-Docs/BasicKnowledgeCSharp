/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 октября 2026 10:21:51
 * Version: 1.0.439
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