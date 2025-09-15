/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 сентября 2025 06:51:33
 * Version: 1.0.27
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