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
            Doctor gary =  new Doctor("Gary Garyson", 63543435435, "gaaaah@gmail.com", 200000);
            Doctor bary =  new Doctor("Bary Baryson", 63549825435, "baaaah@gmail.com",  5100000);
            Doctor allen = new Doctor("Allen Allenson", 63543435435, "aaaaah@gmail.com", 33);
            Person steve = new Person("Jerry", 4654246846, "jaaaah@gmail.com");
            Person larry = new Person("Larry", 3546843248, "laaaah@gmail.com");

            team[0] = gary;
            team[1] = bary;
            team[2] = allen;
            team[3] = steve;
            team[4] = larry;
            //Random r = new Random();
            //int random = r.Next(1,3);
            //Console.WriteLine(random);

            for (int i = 0; i < team.Length; i++)
            {
                team[i].SayGreeting();
                Console.WriteLine("\n");
                //Console.WriteLine(team[i].name);
            }

            /*
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
            */
            Console.ReadKey();
        }
    }
}
