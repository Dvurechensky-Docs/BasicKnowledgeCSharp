/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 апреля 2026 13:05:08
 * Version: 1.0.225
 */

using System;

/*
 * 3. Напишите простой конвертер валют
 *    (без возможности динамического выбора валюты пользователем).
 *    Валюты заданы хардкодом и не изменяются. Тип валют на выбор программиста.
 */
class Program
{
    static void Main()
    {
        double ruble, dollar;

        Console.WriteLine("Введите количество рублей: ");

        double.TryParse(Console.ReadLine(), out ruble);

        dollar = ruble * 0.014;

        Console.WriteLine("Долларов: " + dollar);
        Console.ReadKey();
    }
}