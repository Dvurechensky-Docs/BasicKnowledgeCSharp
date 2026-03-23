/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 марта 2026 13:10:42
 * Version: 1.0.216
 */

using System;
using Students;

namespace Extension
{
    static class MyExtensions
    {
        public static void Print(this DateTime dateTime)
        {
            Console.WriteLine($"{dateTime.Day} {dateTime.Month} {dateTime.Year}");
        }

        public static bool IsDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            return dateTime.DayOfWeek == dayOfWeek;
        }

        public static string GetFullName(this Student student)
        {
            return student.LastName + " " + student.FirstName;
        }
    }
}
