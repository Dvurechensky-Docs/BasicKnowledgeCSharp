/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 октября 2025 10:57:44
 * Version: 1.0.58
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