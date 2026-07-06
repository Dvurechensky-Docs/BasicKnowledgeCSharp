/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 июля 2026 13:33:35
 * Version: 1.0.324
 */

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Address Address { get; set; }
    public override string ToString()
    {
        return $"FirstName: {FirstName}, LastName: {LastName} ";
    }
}