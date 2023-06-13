using System;
using System.Collections.Generic;
using System.Text;

namespace Greetings
{
    public class Person
    {
        public string name;
        public float phoneNumber;
        public string emailAdress;
        
        public virtual void SayGreeting()
        {
            Console.WriteLine("Hello, I'm " + name);

        }

        public Person()
        {

        }
        public Person(string Name, float PhoneNumber, string EmailAdress)
        {
            name = Name;
            phoneNumber = PhoneNumber;
            emailAdress = EmailAdress;
        }

    }
    

    

        
      
}
