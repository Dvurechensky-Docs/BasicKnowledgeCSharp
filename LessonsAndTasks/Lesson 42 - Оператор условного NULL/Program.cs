/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 июня 2026 08:46:48
 * Version: 1.0.293
 */

using System;
using System.Linq;

/*
 * Оператор условного NULL ?.
 */
class Program
{
    static int[] GetArray()
    {
        int[] myArray = null;
        return myArray;
    }

    static void Main()
    {
        int[] myArray = GetArray();
        // ?. - проверяет равна ли сумма null или не равна 
        // ?? - оператор объединения с null  
        Console.WriteLine(myArray?.Sum() ?? -1);
        Console.ReadKey();
    }
}