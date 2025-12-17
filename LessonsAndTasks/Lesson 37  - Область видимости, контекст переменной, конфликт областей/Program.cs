/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 декабря 2025 15:24:47
 * Version: 1.0.120
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