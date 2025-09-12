/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 сентября 2025 15:29:39
 * Version: 1.0.24
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