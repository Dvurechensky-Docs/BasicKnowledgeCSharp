/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 декабря 2025 11:19:58
 * Version: 1.0.106
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