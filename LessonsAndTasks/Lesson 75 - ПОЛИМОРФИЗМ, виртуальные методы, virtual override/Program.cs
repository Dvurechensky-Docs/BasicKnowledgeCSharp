/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 февраля 2026 06:51:32
 * Version: 1.0.171
 */

using System;

/*
 * Полиморфизм
 * 
 * виртуальные методы
 * 
 * virtual
 * 
 * override
 */
/// <summary>
/// virtual и override - дают возможность переопределить работу методов в классе наследнике
/// </summary>
class Motor
{
    /// <summary>
    /// Чтобы метод был доступен на уровно наследника вместо private ставим protected
    /// </summary>
    protected virtual void StartEngine()
        => Console.WriteLine("Двигатель запущен!");

    /// <summary>
    /// Чтобы переопределить метод для новой реализации в наследнике
    /// </summary>
    public virtual void Drive()
    {
        StartEngine();
        Console.WriteLine("Я еду!");
    }
}

class SportMotor : Motor
{
    protected override void StartEngine() => Console.WriteLine("Рон дон дон");

    /// <summary>
    /// Переопределение виртуального метода
    /// </summary>
    public override void Drive()
    {
        StartEngine();
        Console.WriteLine("Я быстро еду!");
    }
}

class Stable
{
    public void Drive(Motor motor) => motor.Drive();
}

class Program
{
    static void Main()
    {
        var stable = new Stable();
        stable.Drive(new SportMotor());
        Console.ReadKey();
    }
}