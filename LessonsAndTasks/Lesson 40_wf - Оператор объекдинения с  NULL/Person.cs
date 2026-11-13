/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 ноября 2026 06:50:55
 * Version: 1.0.453
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