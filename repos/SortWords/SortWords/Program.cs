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
            int i = 0; 
            
            //string line;
            StreamReader reader = new StreamReader("input.txt");
            string allText = reader.ReadToEnd();
            string[] lines = allText.Split('\n');
            
            List<string> list = new List<string>(lines);
            list.RemoveAt(0);
            
            
            
            
            //string items = "13";
            //List<string> nums = new List<string>(lines);
            //nums.RemoveAt(nums.IndexOf(items));
            //lines = nums.ToArray();
            
            //Console.WriteLine(lines[2]);

            string[] sorted = lines.OrderBy(x => x).ToArray();

            foreach (var item in sorted)
            {
              Console.WriteLine(item);
            }


            StreamWriter writer;
            
            writer = new StreamWriter("Output.txt");


            foreach (var item in sorted)
                
            {
                
                writer.Write(sorted[i]);
                i++;
            }
            
            writer.Close();

            reader.Close();


            /*
            //while loop finds the amount of lines "i" that the array will store
            while (reader.EndOfStream == false)
            {
                
                reader.ReadLine();
                i++;

            }            
            string[] lines = new string[i];
            //entering values into array
            while (reader.EndOfStream == false)
            {

                line = reader.ReadLine();
                lines[i] = line;
                Console.WriteLine(line);


            }
            foreach (string item in lines)
            {
                Console.WriteLine(item);
            }
            StreamWriter writer;
            writer = new StreamWriter("Output.txt");
            int j = 0;
            while (i>j)
            {
                writer.WriteLine(lines[j]);

                j++;
            }
            
            writer.Close();

            reader.Close();
            */


        }
    }
}
