/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 марта 2026 10:04:15
 * Version: 1.0.219
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
