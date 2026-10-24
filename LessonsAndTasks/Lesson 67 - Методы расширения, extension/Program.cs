/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 октября 2026 10:25:33
 * Version: 1.0.433
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