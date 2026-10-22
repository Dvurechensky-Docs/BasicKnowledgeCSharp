/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 октября 2026 09:49:04
 * Version: 1.0.431
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