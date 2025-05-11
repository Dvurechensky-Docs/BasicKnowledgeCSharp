/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
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