/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 августа 2026 08:31:46
 * Version: 1.0.376
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