/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 апреля 2026 12:31:20
 * Version: 1.0.234
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