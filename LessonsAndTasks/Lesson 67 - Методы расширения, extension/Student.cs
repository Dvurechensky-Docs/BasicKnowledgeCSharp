/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 июня 2026 06:51:23
 * Version: 1.0.316
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
