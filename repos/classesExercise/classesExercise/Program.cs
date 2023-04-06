using System;

namespace classesExercise
{
    internal class Program
    {
        static void Main()
        {
            Team team = new Team();
            int employeeCount = 5;
            team.employees = new Employee[employeeCount];

            Employee employee = new Employee("Adam", "Schmidt", 50);
            team.employees[0] = employee;

            team.employees = InputEmployees();


            /*
            int Position = 0;
            bool pressed = false;
            while (pressed|| Position <10)
            {
                pressed = false;

                int userInput3 = int.Parse(Console.ReadLine());
                if (userInput3 == 2)
                {
                    pressed = true;
                }
                Position++;

                //int n = 10;
            }
            */
            team.DisplayArray();


            static Employee[] InputEmployees()
            {
                Employee[] employees = new Employee[5];
                float average = 0;

                for (int i = 0; i < employees.Length; i++)
                {
                    Console.WriteLine("Enter first name");
                    string userInput = Console.ReadLine();
                    Console.WriteLine("Enter last name");
                    string userInput1 = Console.ReadLine();
                    Console.WriteLine("Enter years of experience");
                    int userInput2 = Int32.Parse(Console.ReadLine());

                    Employee employee = new Employee(userInput, userInput1, userInput2);
                    employees[i] = employee;


                    average += employees[i].yearsOfExperince;





                    Console.Clear();
                }
                average = average / employees.Length;
                Console.WriteLine(average);
                return employees;
            }
        }
    }
}

