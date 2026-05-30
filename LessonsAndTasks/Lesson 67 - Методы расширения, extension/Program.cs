/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 мая 2026 15:42:03
 * Version: 1.0.286
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