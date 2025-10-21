/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 октября 2025 14:24:57
 * Version: 1.0.63
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