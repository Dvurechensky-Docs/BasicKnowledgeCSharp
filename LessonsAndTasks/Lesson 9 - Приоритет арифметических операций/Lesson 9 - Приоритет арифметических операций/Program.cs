/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 февраля 2026 10:32:39
 * Version: 1.0.177
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