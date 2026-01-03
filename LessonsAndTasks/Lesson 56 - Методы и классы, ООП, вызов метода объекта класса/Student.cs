/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 января 2026 14:59:29
 * Version: 1.0.137
 */

using System;

class Student
{
    /// <summary>
    /// Cпециальная структура для описания объекта, создания уникальных id
    /// </summary>
    public Guid id;
    public string firstName;
    public string lastName;
    public string middleName;
    public int age;
    public string group;

    public void Print()
    {
        Console.WriteLine($"id: {id}, \nfirstName: {firstName},\n" +
                          $"lastName: {lastName}, \nmiddleName: {middleName},\n" +
                          $"age: {age}, \ngroup: {group}");
    }

    public string GetFullName()
    {
        return $"{lastName} {firstName} {middleName}";
    }
}