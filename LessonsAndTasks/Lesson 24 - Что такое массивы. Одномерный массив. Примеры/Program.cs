/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
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