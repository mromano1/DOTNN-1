using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            string[] dirs = path.Split("\\");

            List<string> needs = new List<string> { };
            foreach (var word in dirs)
            {
                needs.Add(word);
                if (word == "DOTNN")
                {
                    break;
                }
            }

            needs.Add("AutoCrawler");
            needs.Add("main.py");

            var finalPath = string.Join("\\", needs.ToArray());
            Console.WriteLine(finalPath);
            return;
        }

        static public string GetParent(string path)
        {
            try
            {
                System.IO.DirectoryInfo directoryInfo =
                    System.IO.Directory.GetParent(path);

                return directoryInfo.FullName;
            }
            catch (ArgumentNullException)
            {
                System.Console.WriteLine("Path is a null reference.");
                return "";
            }
            catch (ArgumentException)
            {
                System.Console.WriteLine("Path is an empty string, " +
                    "contains only white spaces, or " +
                    "contains invalid characters.");
                return "";
            }
        }
    }
}
