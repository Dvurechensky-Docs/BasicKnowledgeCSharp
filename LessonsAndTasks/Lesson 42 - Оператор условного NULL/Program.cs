/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 апреля 2026 10:57:03
 * Version: 1.0.233
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