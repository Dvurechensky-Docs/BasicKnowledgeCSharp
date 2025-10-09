/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 октября 2025 06:57:12
 * Version: 1.0.51
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