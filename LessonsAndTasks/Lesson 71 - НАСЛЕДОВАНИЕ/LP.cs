/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 февраля 2026 06:51:41
 * Version: 1.0.191
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