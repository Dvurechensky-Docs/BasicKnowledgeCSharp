/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2026 12:04:25
 * Version: 1.0.268
 */

using System;

class LP
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void PrintFullName()
    {
        Console.WriteLine($"Name: {FirstName}, LastName: {LastName}");
    }
}