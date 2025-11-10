/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 ноября 2025 06:51:51
 * Version: 1.0.83
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