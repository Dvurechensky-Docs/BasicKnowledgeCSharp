/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 декабря 2025 10:57:15
 * Version: 1.0.134
 */

using System;

/*
 * двумерный массив
 * 
 * инициализация
 * 
 * обращение к элементам двумерного массива
 */
class Program
{
    static void Main()
    {
        //тип_данных [,] имя_массива;

        int[,] myArray = new int[3, 5];
        int[,] myArray_1 =
        {
            { 34, 44, 55, 22, 33 },
            { 34, 44, 55, 22, 33 },
            { 34, 44, 55, 22, 33 }
        };

        myArray[0, 2] = 90;

        Console.WriteLine(myArray[0, 2]);
        Console.ReadKey();
    }
}