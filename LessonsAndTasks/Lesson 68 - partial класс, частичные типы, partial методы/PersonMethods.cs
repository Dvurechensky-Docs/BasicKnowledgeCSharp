/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 ноября 2025 17:22:50
 * Version: 1.0.75
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