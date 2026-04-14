/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 апреля 2026 12:24:11
 * Version: 1.0.238
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