/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
 */

using System;
using System.Windows.Forms;

namespace Lesson_40_wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Person> GetPerson()
        {
            return new List<Person>()
            {
            new Person() {FirstName = "1", MiddleName = "2", SecondName = "3"},
            new Person() {FirstName = "11", MiddleName = "22", SecondName = "33"},
            new Person() {FirstName = "111", MiddleName = "222"},
            new Person() {FirstName = "unknown", Contacts = new Contacts() { PhoneNumber = "1234"} }
        };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var persons = GetPerson();

            foreach (var person in persons)
            {
                listBox1.Items.Add($"{person.GetFullName()} | {person.GetPhoneNumber()}");
            }
        }
    }
}