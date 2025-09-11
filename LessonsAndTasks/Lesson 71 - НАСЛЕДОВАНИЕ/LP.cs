/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 сентября 2025 06:51:39
 * Version: 1.0.23
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