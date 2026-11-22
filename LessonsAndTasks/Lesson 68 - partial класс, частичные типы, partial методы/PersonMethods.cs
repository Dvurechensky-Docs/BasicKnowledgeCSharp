/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 ноября 2026 12:47:20
 * Version: 1.0.462
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