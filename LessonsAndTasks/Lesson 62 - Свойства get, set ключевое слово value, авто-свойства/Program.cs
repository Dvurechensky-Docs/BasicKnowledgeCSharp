/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 февраля 2026 09:25:57
 * Version: 1.0.182
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