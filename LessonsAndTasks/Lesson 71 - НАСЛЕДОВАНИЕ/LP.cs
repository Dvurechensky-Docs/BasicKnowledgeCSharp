/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 мая 2026 11:41:57
 * Version: 1.0.282
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