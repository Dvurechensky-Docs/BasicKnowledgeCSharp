/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 июня 2026 13:59:49
 * Version: 1.0.300
 */

using System;

/*
 * Сыойства (Properties)
 * 
 * Автоматические свойства (prop)
 */
class Point
{
    private int x;
    public void SetX(int x) => this.x = x;
    public int GetX() => x;
}

class Program
{
    static void Main()
    {
        Point point = new Point();
        point.SetX(5);
        Console.WriteLine(point.GetX());
        Console.ReadKey();
    }
}