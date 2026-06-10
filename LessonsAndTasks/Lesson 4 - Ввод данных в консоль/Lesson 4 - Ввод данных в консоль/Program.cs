/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 июня 2026 06:51:15
 * Version: 1.0.297
 */

using System;

/*
 * Ввод данных в консоль
 */
class Program
{
    static void Main()
    {
        string data;                                    //  Объявление переменной
        data = Console.ReadLine();                      //  Чтение значения с консоли
        Console.WriteLine("Привет " + data + "!!!");    //  Конкатенация
        Console.ReadKey();                              //  Просмотр содержимого
    }
}