/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 декабря 2025 12:56:27
 * Version: 1.0.110
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