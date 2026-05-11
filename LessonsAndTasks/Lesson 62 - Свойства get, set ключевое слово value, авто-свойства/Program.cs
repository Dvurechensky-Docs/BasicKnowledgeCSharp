/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 мая 2026 10:37:18
 * Version: 1.0.267
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