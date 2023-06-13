using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace SortWords
{
    internal class Program
    {

        static void Main()
        {

            //string line;
            StreamReader reader = new StreamReader("input.txt");
            string allText = reader.ReadToEnd();
            string[] lines = allText.Split('\n');
            string[] sorted = lines.OrderBy(x => x).ToArray();

            sorted[0] = null;
            sorted[1] = null;




            foreach (var item in sorted)
            {
                if (item != null)
                {
                    Console.WriteLine(item);

                }
            }


            StreamWriter writer;

            writer = new StreamWriter("Output.txt");


            foreach (var item in sorted)

            {
                if (item != null)
                {

                    writer.Write(item);
                }
            }

            writer.Close();

            reader.Close();

            Console.ReadKey();

            Console.ReadKey();


        }
    }
}
