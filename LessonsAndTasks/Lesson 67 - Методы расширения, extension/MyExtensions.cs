/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 февраля 2026 13:13:02
 * Version: 1.0.185
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
