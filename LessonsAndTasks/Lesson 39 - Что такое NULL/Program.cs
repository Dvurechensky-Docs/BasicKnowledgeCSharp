/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 сентября 2026 07:35:48
 * Version: 1.0.395
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