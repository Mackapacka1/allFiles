using System;
using System.Collections.Generic;
using System.Text;

namespace Greetings
{
    public abstract class Person
    {
        public string name;
        public float phoneNumber;
        public string emailAdress;
        public string greeting;
        public int salary;
        public abstract void SayGreeting();
        public Person(string Name, float PhoneNumber, string EmailAdress,string Greeting, int Salary)
        {
            name = Name;
            phoneNumber = PhoneNumber;
            emailAdress = EmailAdress;
            salary = Salary;
            greeting = Greeting;
        }

    }
    

    

        
      
}
