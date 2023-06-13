using System;
using System.Collections.Generic;
using System.Text;

namespace classesExercise
{
    internal class Employee
    {
        internal static object employee;
        public string firstName;
        public string lastName;
        public int yearsOfExperince;


        //public static object[,] people = new object[10, 3];

        public Employee(string FirstName, string LastName, int YearsOfExperince)
        {
            //people[9, 0] = "baaah";
            //people[9, 1] = "gaaah";
            //people[9, 0] = 4;
            firstName = FirstName;
            lastName = LastName;
            yearsOfExperince = YearsOfExperince;
        

            //people[Position, 0] = firstName;
            //people[Position, 1] = lastName;
            //people[Position, 2] = yearsOfExperince;

        }
        
    }

   
}




