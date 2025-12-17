/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 декабря 2025 15:24:47
 * Version: 1.0.120
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