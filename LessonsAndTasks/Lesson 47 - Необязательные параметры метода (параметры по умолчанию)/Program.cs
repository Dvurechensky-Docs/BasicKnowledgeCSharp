/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 апреля 2026 09:18:35
 * Version: 1.0.255
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