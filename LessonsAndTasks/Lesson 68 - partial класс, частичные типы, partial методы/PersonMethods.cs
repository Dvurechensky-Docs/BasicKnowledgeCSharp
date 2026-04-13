/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 апреля 2026 12:58:47
 * Version: 1.0.237
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