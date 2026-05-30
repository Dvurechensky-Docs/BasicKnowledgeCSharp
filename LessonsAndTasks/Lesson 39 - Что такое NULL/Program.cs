/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 мая 2026 15:42:03
 * Version: 1.0.286
 */

using System;

/*
 * Что такое NULL
 */
class MyClass
{

}

struct MyStruct
{

}

class Program
{
    static void Heap()
    {
        int[] a = new int[10];
    }

    static void Main()
    {
        bool b;
        int a;
        double d;

        //У классов - NULL
        Random random;
        int[] arr;
        MyClass myClass;

        MyStruct myStruct;

        Heap();
        Console.ReadKey();
    }
}