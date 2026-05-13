/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 мая 2026 06:51:14
 * Version: 1.0.269
 */

using System;

/*
 * Инкремент и декремент. Постфиксный и префиксный.
 */
class Program
{
    static void Main()
    {
        int a = 0;
        int b = 1;

        a++; // Постфиксная - Сначала выведется переменная до инкремента а потом после него
        --a; // Префиксная - Сначала сработает увеличение переменной а результат выведется в консоль
        a--;
        a--;

        b = ++b * b;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.ReadKey();
    }
}