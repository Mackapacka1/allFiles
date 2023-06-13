using System;
using System.Collections.Generic;
using System.Text;

namespace classesExercise
{
    internal class Team
    {
        public Employee[] employees;
        public void DisplayArray()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.yearsOfExperince);
            } for (int i = 0; i < employees.Length; i++) {
               
        }
        }

    }
}
