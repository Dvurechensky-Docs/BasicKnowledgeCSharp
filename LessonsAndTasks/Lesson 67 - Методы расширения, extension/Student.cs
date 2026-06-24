/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 июня 2026 10:33:25
 * Version: 1.0.311
 */

namespace Students
{
    /// <summary>
    /// Не можем унаследоваться от этого класса - sealed
    /// </summary>
    sealed class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
