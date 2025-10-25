/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 октября 2025 06:51:30
 * Version: 1.0.67
 */

/*
 * Частичные типы
 * 
 * partial классы (паршиал)
 * 
 * partial методы
 */
using System;
/// <summary>
/// Позволяет код класса произнести в разных файлах (класс превращается в частичный)
/// </summary>
class Program
{
    static void Main()
    {
        Person person = new Person("Джим", "Керри");
        person.PrintFullName();
        Console.ReadKey();
    }
}