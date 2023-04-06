using System;
using System.Collections.Generic;
using System.Text;

namespace Greetings
{
    public class Doctor : Person
    {
        public override void SayGreeting()
        {
            Console.WriteLine(greeting + name);
        }
        

        public Doctor(string Name, float PhoneNumber, string EmailAdress, string Greeting, int Salary) : base(Name, PhoneNumber, EmailAdress, Greeting, Salary)
        {
            greeting = Greeting;
            name = Name;
        }
    }
}
