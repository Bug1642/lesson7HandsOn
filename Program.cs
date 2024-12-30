using System;
namespace lesson7HandsOn
{
    public class Employee
    {
        string name;
        string salary;
        string hireDate;
        public Employee(string name, string salary, string hireDate)
        {
            this.name = name;
            this.salary = salary;
            this.hireDate = hireDate;
        }
        public virtual void getname()
        {
            Console.WriteLine("Employee Name: " + name);
        }
        public virtual void getSalary()
        {
            Console.WriteLine("Salary: " + salary);
        }
        public virtual void hiredDate()
        {
            Console.WriteLine("Hire Date: " + hireDate);
        }
    }
    public class Engineer : Employee 
    {
        string schoolAttended;

        public Engineer(string name, string salary, string hireDate, string schoolAttended) 
            : base(name,salary,hireDate) 
        {
            this.schoolAttended = schoolAttended;
        }

    }
    public class SoftwareEngineer : Engineer
    {
        public SoftwareEngineer(string name, string salary, string hireDate, string schoolAttended)
            : base(name, salary, hireDate, schoolAttended)
        { 
        }
        public override void getSalary()
        { 
            Console.WriteLine("Salary: Sorry, this employee’s salary is private.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Engineer engineer = new Engineer("Rupert Scott", "42000", "11/22/12","MIT");
            engineer.getname();
            engineer.getSalary();
            engineer.hiredDate();
            Console.WriteLine("-------------------");
            SoftwareEngineer softwareEngineer = new SoftwareEngineer("Shea Rovington", "100","03/27/18","MIT");
            softwareEngineer.getname();
            softwareEngineer.getSalary();
            softwareEngineer.hiredDate();
        }
    }
}