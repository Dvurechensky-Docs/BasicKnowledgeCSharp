/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:07:24
 * Version: 1.0.9
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