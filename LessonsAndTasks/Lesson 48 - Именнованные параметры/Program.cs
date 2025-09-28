/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 сентября 2025 21:13:57
 * Version: 1.0.40
 */

using System;

/*
 * Именнованные параметры
 */

class Program
{
    /// <summary>
    /// Параметры по умолчанию всегда должны быть в конце списка
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="enableLogging"></param>
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
        Sum(a: 1, b: 2);

        int firstValue = 2;
        int secondValue = 3;

        //Чтобы внести ясность тому что выполнит функция 
        Sum(a: firstValue, b: secondValue, enableLogging: true);
        Console.ReadKey();
    }
}