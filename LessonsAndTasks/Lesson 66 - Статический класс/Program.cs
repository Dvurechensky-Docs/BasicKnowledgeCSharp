/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 июня 2026 13:24:50
 * Version: 1.0.298
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