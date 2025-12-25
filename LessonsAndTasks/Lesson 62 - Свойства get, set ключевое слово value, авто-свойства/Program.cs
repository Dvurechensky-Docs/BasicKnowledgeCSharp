/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 декабря 2025 09:30:16
 * Version: 1.0.128
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