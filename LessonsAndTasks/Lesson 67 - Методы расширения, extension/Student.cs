/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 октября 2025 17:06:50
 * Version: 1.0.72
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
