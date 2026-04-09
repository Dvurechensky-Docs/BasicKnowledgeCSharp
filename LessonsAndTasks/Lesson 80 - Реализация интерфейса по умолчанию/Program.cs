/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 апреля 2026 10:57:03
 * Version: 1.0.233
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