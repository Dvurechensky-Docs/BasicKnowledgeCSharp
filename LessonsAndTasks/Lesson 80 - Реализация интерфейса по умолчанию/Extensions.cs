/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 октября 2025 10:14:31
 * Version: 1.0.56
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