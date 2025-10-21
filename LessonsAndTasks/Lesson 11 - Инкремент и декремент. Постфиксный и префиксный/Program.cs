/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 октября 2025 14:24:57
 * Version: 1.0.63
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