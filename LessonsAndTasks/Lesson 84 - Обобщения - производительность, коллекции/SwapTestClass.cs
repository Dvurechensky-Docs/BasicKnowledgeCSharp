/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 мая 2026 15:26:04
 * Version: 1.0.263
 */

public class SwapTestClass
{
    public static void GenericSwap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    public static void Swap(ref object a, ref object b)
    {
        object temp = a;
        a = b;
        b = temp;
    }
}