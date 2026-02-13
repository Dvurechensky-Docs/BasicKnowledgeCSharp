/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 февраля 2026 11:49:53
 * Version: 1.0.178
 */

using System;

/*
 * Массивы
 * 
 * Одномерные массивы
 * 
 * Тип_элементов_массива [] имя_массива;
 */
class Program
{
    static void Main()
    {
        int[] myArray;

        myArray = new int[5];

        myArray[0] = 10;
        myArray[1] = 3;

        int a = myArray[0];

        Console.WriteLine(a);

        Console.ReadKey();
    }
}