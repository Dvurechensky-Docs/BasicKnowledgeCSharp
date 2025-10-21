/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 октября 2025 14:24:57
 * Version: 1.0.63
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