/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
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