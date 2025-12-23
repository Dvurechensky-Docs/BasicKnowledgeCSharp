/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 декабря 2025 10:47:17
 * Version: 1.0.126
 */

using System;

/*
 * Область видимости, или контекст переменной
 * Конфликты областей видимости
 */
class Program
{
    static int a = 3;
    static int aa = 3;

    static void Foo()
    {
        int b = 0;

        int aa = 2;
        Console.WriteLine(aa);
    }

    static void Main()
    {
        for (int i = 0; i < 2; i++)
        {
            ++i;
        }
        Foo();
        a++; // Область видимости и конктекст переменной - это одно и то же
        Console.ReadKey();
    }
}