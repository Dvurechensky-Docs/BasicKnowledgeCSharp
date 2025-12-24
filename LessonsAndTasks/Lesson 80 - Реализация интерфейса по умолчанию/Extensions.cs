/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 декабря 2025 09:28:54
 * Version: 1.0.127
 */

using System;

/// <summary>
/// Методы расширения
/// </summary>
public static class Extensions
{
    public static void Foo(this ILogger logger)
        => Console.WriteLine("Extension Foo()");
}