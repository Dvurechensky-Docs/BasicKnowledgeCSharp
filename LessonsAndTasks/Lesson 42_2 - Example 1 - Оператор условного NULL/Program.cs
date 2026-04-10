/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 апреля 2026 12:31:20
 * Version: 1.0.234
 */

using System;

/*
 * Оператор условного null
 */
class Program
{
    private static Person GetPerson()
    {
        Person person = null;
        return person;
    }

    static void Main()
    {
        Person person = null;

        Console.WriteLine(person?.Contacts?.PhoneNumber ?? "no data");

        person = GetPerson();

        // person, Contacts и PhoneNumber - ссылочные типы - так как они class
        Console.WriteLine(person?.Contacts?.PhoneNumber ?? "no data");
        Console.ReadKey();
    }
}

public class Person
{
    public Contacts Contacts { get; set; }
}

public class Contacts
{
    public string PhoneNumber { get; set; }
}