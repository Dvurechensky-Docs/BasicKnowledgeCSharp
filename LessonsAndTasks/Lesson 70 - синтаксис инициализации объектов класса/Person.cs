/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 января 2026 06:51:30
 * Version: 1.0.160
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