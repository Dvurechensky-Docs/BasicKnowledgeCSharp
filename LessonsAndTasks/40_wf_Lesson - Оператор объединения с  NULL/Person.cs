﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 сентября 2025 11:50:13
 * Version: 1.0.38
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
