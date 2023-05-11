using System;
using System.Collections.Generic;
using System.Text;

namespace Greetings
{
    public class Doctor : Person
    {
        public int salary;
        public override void SayGreeting()
        {
            Console.WriteLine("Hello, I'm doctor "+ name);
        }
        public Doctor()
        {

        }

        public Doctor(string Name, float PhoneNumber, string EmailAdress, int Salary)
        {
            name = Name;
        }
    }
}
