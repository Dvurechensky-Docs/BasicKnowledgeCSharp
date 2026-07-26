/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 июля 2026 15:10:07
 * Version: 1.0.344
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