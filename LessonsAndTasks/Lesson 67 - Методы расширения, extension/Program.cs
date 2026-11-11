/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 ноября 2026 09:14:06
 * Version: 1.0.451
 */

using System;
using Extension;
using Students;

/*
 * Extension методы (метод расширения) (расширяющие методы)
 */
class Program
{
    static void Main()
    {
        DateTime currentDateTime = DateTime.Now;
        currentDateTime.Print();
        Console.WriteLine(currentDateTime.IsDayOfWeek(DayOfWeek.Monday));
        Student student = new Student() { FirstName = "Джим", LastName = "Керри" };
        Console.WriteLine(student.GetFullName());
        Console.ReadKey();
    }
}