/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 ноября 2025 06:51:31
 * Version: 1.0.86
 */

using System;

class Car
{
    private int speed = 0;

    /// <summary>
    /// Пример инкапсуляции поля speed
    /// </summary>
    public void PrintSpeed()
    {
        if (speed == 0)
            Console.WriteLine("Стоим на месте");
        if (speed > 0)
            Console.WriteLine($"Едем вперед со скоростью {speed} км\\ч");
        if (speed < 0)
            Console.WriteLine($"Едем назад со скоростью {-speed} км\\ч");
    }

    public void DriveForward()
    {
        speed = 60;
    }

    public void Stop()
    {
        speed = 0;
    }

    public void DriveBackward()
    {
        speed = -60;
    }
}