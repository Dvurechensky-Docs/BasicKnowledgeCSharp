/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 мая 2026 10:02:49
 * Version: 1.0.276
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
