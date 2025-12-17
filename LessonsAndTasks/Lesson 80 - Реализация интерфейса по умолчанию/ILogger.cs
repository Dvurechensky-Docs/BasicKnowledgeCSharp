/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 декабря 2025 15:24:47
 * Version: 1.0.120
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