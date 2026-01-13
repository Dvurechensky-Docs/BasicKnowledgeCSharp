/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 января 2026 13:16:21
 * Version: 1.0.147
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