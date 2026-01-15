/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 января 2026 17:29:39
 * Version: 1.0.149
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