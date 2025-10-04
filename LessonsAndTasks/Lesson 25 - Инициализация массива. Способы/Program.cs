/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 октября 2025 06:51:31
 * Version: 1.0.46
 */

using System;
using System.Linq;

/*
 * Массивы
 * 
 * Одномерные массивы
 * 
 * Способы инициализации массива
 */
class Program
{
    static void Main()
    {
        int[] myArray_1 = new int[5] { 5, 6, 7, 8, 9 };
        int[] myArray_2 = new int[] { 5, 6, 7, 8 };
        int[] myArray_3 = new[] { 5, 6, 7, 8 };
        int[] myArray_4 = { 5, 6, 7, 8 };
        int[] myArray_5 = Enumerable.Repeat(5, 10).ToArray();
        int[] myArray_6 = Enumerable.Range(4, 5).ToArray();

        Console.ReadKey();
    }
}