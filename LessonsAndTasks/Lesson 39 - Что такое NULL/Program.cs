/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 декабря 2025 13:31:17
 * Version: 1.0.129
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