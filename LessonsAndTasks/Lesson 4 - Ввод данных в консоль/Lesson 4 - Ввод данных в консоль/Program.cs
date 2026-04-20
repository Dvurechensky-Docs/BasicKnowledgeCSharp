/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 16:20:49
 * Version: 1.0.244
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