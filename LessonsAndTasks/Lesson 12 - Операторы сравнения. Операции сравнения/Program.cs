/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 декабря 2025 10:57:15
 * Version: 1.0.134
 */

using System;

/*
 * Операторы отношений.
 * Операции сравнения.
 */

/*
    == Равно
    != Не равно
    >  Больше
    <  Меньше
    >= Больше или равно
    <= Меньше или равно
*/
class Program
{
    static void Main()
    {
        int a = 5, b = 4;
        bool result0 = a == b;
        bool result1 = a != b;
        bool result2 = a > b;
        bool result3 = a < b;
        bool result4 = a <= b;
        bool result5 = a >= b;
        Console.WriteLine(result0 + Environment.NewLine +
                          result1 + Environment.NewLine +
                          result2 + Environment.NewLine +
                          result3 + Environment.NewLine +
                          result4 + Environment.NewLine +
                          result5 + Environment.NewLine);
        Console.ReadKey();
    }
}