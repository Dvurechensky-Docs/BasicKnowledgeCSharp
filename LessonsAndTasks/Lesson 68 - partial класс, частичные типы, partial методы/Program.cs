/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 марта 2026 13:10:42
 * Version: 1.0.216
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