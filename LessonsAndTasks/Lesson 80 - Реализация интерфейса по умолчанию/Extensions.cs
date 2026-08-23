/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 августа 2026 06:51:20
 * Version: 1.0.372
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