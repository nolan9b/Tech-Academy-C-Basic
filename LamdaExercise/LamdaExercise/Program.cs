using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the ten employees
            Employee peter = new Employee();
            peter.FirstName = "Peter";
            peter.LastName = "Pan";
            peter.Id = 1;

            Employee wendy = new Employee();
            wendy.FirstName = "wendy";
            wendy.LastName = "darling";
            wendy.Id = 2;

            Employee hook = new Employee();
            hook.FirstName = "hook";
            hook.LastName = "captain";
            hook.Id = 3;

            Employee sme = new Employee();
            sme.FirstName = "sme";
            sme.LastName = "mr";
            sme.Id = 4;

            Employee tinker = new Employee();
            tinker.FirstName = "joe";
            tinker.LastName = "bell";
            tinker.Id = 5;

            Employee frodo = new Employee();
            frodo.FirstName = "frodo";
            frodo.LastName = "baggins";
            frodo.Id = 6;

            Employee aragorn = new Employee();
            aragorn.FirstName = "aragorn";
            aragorn.LastName = "son of arathorn";
            aragorn.Id = 7;

            Employee boromir = new Employee();
            boromir.FirstName = "boromir";
            boromir.LastName = "heir of denethor";
            boromir.Id = 8;

            Employee gandalf = new Employee();
            gandalf.FirstName = "gandalf";
            gandalf.LastName = "the grey";
            gandalf.Id = 9;

            Employee gimli = new Employee();
            gimli.FirstName = "joe";
            gimli.LastName = "son of gloin";
            gimli.Id = 10;

            // Add employees to list
            List<Employee> employees = new List<Employee>();
            employees.Add(peter);
            employees.Add(wendy);
            employees.Add(hook);
            employees.Add(sme);
            employees.Add(tinker);
            employees.Add(frodo);
            employees.Add(aragorn);
            employees.Add(boromir);
            employees.Add(gandalf);
            employees.Add(gimli);

            // Create a new list to store employees with name of joe
            List<Employee> newList = new List<Employee>();
            Console.WriteLine("Normal list");
            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "joe")
                {
                    newList.Add(emp);
                }
            }

            // Create a list using a lambda expression
            Console.WriteLine("Lambda expression list.");
            List<Employee> lamdaList = new List<Employee>();

            foreach (Employee emp in employees.Where(x => x.FirstName == "joe" ))
            {
                lamdaList.Add(emp);
            }

            List<Employee> lamdaIDList = new List<Employee>();

            foreach (Employee emp in employees.Where(x => x.Id >5))
            {
                lamdaIDList.Add(emp);
            }

            foreach (Employee emp in lamdaIDList)
            {
                Console.WriteLine(emp.FirstName);
            }

            Console.ReadLine();
        }
    }
}
