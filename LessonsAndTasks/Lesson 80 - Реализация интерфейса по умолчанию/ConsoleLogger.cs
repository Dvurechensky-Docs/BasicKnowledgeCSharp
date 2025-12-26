/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 декабря 2025 13:31:17
 * Version: 1.0.129
 */

using System;

class ConsoleLogger : ILogger
{
    public void Log(LogLevel logLevelm, string message)
    {
        switch (logLevelm)
        {
            case LogLevel.Debug:
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case LogLevel.Info:
                Console.ForegroundColor = ConsoleColor.White;
                break;
            case LogLevel.Warning:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case LogLevel.Error:
            case LogLevel.Fatal:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
        }
        Console.WriteLine($"{DateTime.Now}: {message}");
        Console.ResetColor();
    }
}