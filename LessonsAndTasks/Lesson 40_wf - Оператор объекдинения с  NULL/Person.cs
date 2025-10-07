/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 октября 2025 08:38:21
 * Version: 1.0.49
 */

public class Person
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string SecondName { get; set; }

    public Contacts Contacts { get; set; }

    public string GetFullName()
    {
        return $"Фамилия: {FirstName ?? "нет данных"} | Имя: {MiddleName ?? "нет данных"} | Отчество: {SecondName ?? "нет данных"}";
    }

    public string GetPhoneNumber()
    {
        return $"Phone Number: {Contacts?.PhoneNumber ?? "нет данных"}";
    }
}