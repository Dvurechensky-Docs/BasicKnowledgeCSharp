﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 сентября 2025 06:51:35
 * Version: 1.0.28
 */

/*
 * реализация интерфейса по умолчанию в C# 8.0
 */
using System;

class Program
{
    static void Main()
    {
        ILogger logger = new ConsoleLogger();
        logger.Foo();
        logger.Bar();
        logger.Sum(1, 3);
        logger.Log(LogLevel.Debug, "some event");
        logger.Log(LogLevel.Warning, "some warning");
        logger.Log(LogLevel.Fatal, "some fatal");
        Console.ReadKey();
    }
}