/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 декабря 2025 10:57:15
 * Version: 1.0.134
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