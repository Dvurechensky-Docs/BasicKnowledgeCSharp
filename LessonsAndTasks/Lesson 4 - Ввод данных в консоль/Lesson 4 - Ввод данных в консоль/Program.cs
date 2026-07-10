/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 июля 2026 11:53:28
 * Version: 1.0.328
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