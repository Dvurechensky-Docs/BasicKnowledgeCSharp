/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 октября 2025 08:49:06
 * Version: 1.0.53
 */

using System;


/*
 * 3. Напишите простой конвертер валют
 *    (без возможности динамического выбора валюты пользователем).
 *    Валюты заданы хардкодом и не изменяются. Тип валют на выбор программиста.
 */

namespace Task_Home_3___Конвертер_валют
{
    class Program
    {
        static void Main(string[] args)
        {
            //#3
            double ruble, dollar;

            Console.WriteLine("Введите количество рублей: ");

            double.TryParse(Console.ReadLine(), out ruble);

            dollar = ruble * 0.014;

            Console.WriteLine("Долларов: " + dollar);
        }
    }
}
