using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDz
{
    internal enum Profile
    {
        Marketing = 1,
        IT = 2,
        Food = 3,
        Finance = 4,
        Education = 5
    }
    internal class Firm
    {
        public string Name { get; set; }
        public DateOnly Date {  get; set; }
        public Profile Profile { get; set; }
        public string CEO { get; set; }
        public List<Employee> Employees { get; set; }
        public string Address { get; set; }

        public Firm(string name, DateOnly date, Profile profile, string ceo, Employee[] employees, string address)
        {
            Name = name;
            Date = date;
            Profile = profile;
            CEO = ceo;
            Employees = new List<Employee>(employees);
            Address = address;
        }

        public override string ToString()
        {
            return $"Firm: {Name}, Date: {Date}, Profile: {Profile}, CEO: {CEO}, Employees Count: {Employees.Count}, Address: {Address}";
        }
    }
}
