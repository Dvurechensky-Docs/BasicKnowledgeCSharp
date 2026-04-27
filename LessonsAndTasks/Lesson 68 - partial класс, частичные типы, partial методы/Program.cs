/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 апреля 2026 09:40:12
 * Version: 1.0.252
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