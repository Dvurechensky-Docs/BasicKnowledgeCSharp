/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 января 2026 15:46:23
 * Version: 1.0.139
 */

using System;

/*
 * Необязательные параметры методов
 */
class Program
{
    /// <summary>
    /// Параметры по умолчанию всегда должны быть в конце списка
    /// </summary>
    /// <param name="a">#</param>
    /// <param name="b">#</param>
    /// <param name="enableLogging">Logging</param>
    /// <returns></returns>
    private static int Sum(int a, int b, bool enableLogging = false)
    {
        int result = a + b;

        if (enableLogging)
        {
            Console.WriteLine($"Значение переменной a = {a}");
            Console.WriteLine($"Значение переменной b = {b}");
            Console.WriteLine($"Значение переменной result = {result}");
        }

        return result;
    }

    static void Main()
    {
        Sum(2, 3);
        Console.ReadKey();
    }
}