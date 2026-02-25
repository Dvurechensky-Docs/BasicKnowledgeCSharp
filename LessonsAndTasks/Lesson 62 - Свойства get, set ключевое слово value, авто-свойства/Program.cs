/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 февраля 2026 14:01:03
 * Version: 1.0.190
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