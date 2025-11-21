/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 ноября 2025 09:30:35
 * Version: 1.0.94
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