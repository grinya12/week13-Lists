using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ListsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"/Users/GRI$$$HA/Projects/Lists/Data/fruit.txt";
            List<string> fileContent = File.ReadAllLines(filePath).ToList();

            Console.WriteLine("Original file content>");
            DisplayListElements(fileContent);

            Console.WriteLine("Update list content");
            //fileContent.Add("almond");
            //DisplayListElements(fileContent);

            int indexOfTomato = fileContent.IndexOf("tomato");
            Console.WriteLine($"Tomato is located at index {indexOfTomato}");
            //fileContent.RemoveAt(indexOfTomato);

            DisplayListElements(fileContent);

            File.WriteAllLines(filePath, fileContent);
        }

        public static void DisplayListElements(List<string> someList)
        {
            foreach(string element in someList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
