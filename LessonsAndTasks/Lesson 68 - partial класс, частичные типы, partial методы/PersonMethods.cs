/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 июня 2026 18:20:28
 * Version: 1.0.294
 */

partial class Person
{
    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }

    public void PrintFullName() // partial
    {
        System.Console.WriteLine(GetFullName());
    }
}