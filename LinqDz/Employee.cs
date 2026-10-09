using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDz
{
    internal enum Position
    {
        Manager = 1,
        CEO = 2,
        Worker = 3,
        Employer = 4
    }
    internal class Employee
    {
        public string Pib {  get; set; }
        public Position Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }

        public Employee(string pib, Position position, string phone, string email, int salary)
        {
            Pib = pib;
            Position = position;
            Phone = phone;
            Email = email;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Employee: {Pib}, Position: {Position}, Phone: {Phone}, Email: {Email}, Salary: {Salary}";
        }
    }
}
