using System;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Greetings
{
    internal class Program
    {
        

        static void Main()
        {
            
            Person[] team = new Person[5];
            Doctor gary =  new Doctor("Gary Garyson", 63543435435, "gaaaah@gmail.com", "hi im doctor ", 200000);
            Doctor bary =  new Doctor("Bary Baryson", 63549825435, "baaaah@gmail.com", "sup im doctor ", 5100000);
            Doctor allen = new Doctor("Allen Allenson", 63543435435, "aaaaah@gmail.com", "good morning im doctor ", 33);

            team[0] = gary;
            team[1] = bary;
            team[2] = allen;
            Random r = new Random();
            int random = r.Next(1,3);
            Console.WriteLine(random);

            switch (random)
            {
                case 1:
                    allen.SayGreeting();
                    break;
                case 2:
                    bary.SayGreeting();
                    break;
                case 3:
                    gary.SayGreeting();
                    break;

            }
        }
    }
}
