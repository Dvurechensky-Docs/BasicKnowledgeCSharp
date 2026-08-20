/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 августа 2026 09:35:22
 * Version: 1.0.369
 */

using System;

/*
 * Ключевое слово static
 * 
 * Статический класс
 */
static class Herro
{
    public static void Foo() => Console.WriteLine("Вызвал Foo()");
}

class Program
{
    static void Main()
    {
        Herro.Foo();
        Console.ReadKey();
    }
}