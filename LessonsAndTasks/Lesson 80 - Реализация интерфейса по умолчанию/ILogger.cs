/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 ноября 2026 09:37:24
 * Version: 1.0.442
 */

using System;

/// <summary>
/// *не желательно смешивать реализацию и абстракцию,
/// *то есть все методы интерфейса должны реализовываться вне их пространства
/// Интерфейс - это конктракт взаимодействия
/// тоесть возможность писать реализации методов прямов интерфейсе
/// имеет смысл если этот интерфейс реализует множество разных классов
/// тогда не нужно в каждом из них писать дополнительную реализацию нового метода
/// </summary>
public interface ILogger
{
    void Log(LogLevel logLevelm, string message);
    void Bar() => Console.WriteLine("Bar");
    int Sum(int a, int b) => a + b;
}