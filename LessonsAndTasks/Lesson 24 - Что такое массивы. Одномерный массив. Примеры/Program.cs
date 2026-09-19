/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 сентября 2026 08:44:34
 * Version: 1.0.399
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