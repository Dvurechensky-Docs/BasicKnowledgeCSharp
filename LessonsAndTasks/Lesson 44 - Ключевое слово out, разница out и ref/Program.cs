﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 октября 2025 08:38:21
 * Version: 1.0.49
 */

using System;
using System.Text;

/*
 * Ключевое слово out
 * Разница между ref и out
 */
class Program
{
    public static void Foo(ref int value)
    {
        value++;
        System.Console.WriteLine(value);
    }

    /// <summary>
    /// Change input val
    /// out - обязывает нас присваивать значение переменной внутри метода
    /// </summary>
    /// <param name="value">value</param>
    public static void Bar(out int value)
    {
        value = 0;
        System.Console.WriteLine(value);
    }

    static void Main()
    {
        int a = 10;
        int aa;
        Foo(ref a);
        Bar(out aa);
        string str = "3";
        int.TryParse(str, out int result);
        Bar(out int aaa);   // сразу можем объявить внутри метода с out
        Console.ReadKey();
    }
}