/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 ноября 2025 14:37:00
 * Version: 1.0.103
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