/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 апреля 2026 09:40:12
 * Version: 1.0.252
 */

namespace Lesson_40_wf
{
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
}
