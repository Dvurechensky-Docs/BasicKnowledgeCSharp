/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 октября 2026 09:03:43
 * Version: 1.0.434
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