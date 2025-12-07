/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 декабря 2025 12:56:27
 * Version: 1.0.110
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