using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingListDirectoryAndFile2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopActive = true;

            while (loopActive)
            {
                string rootDirectory = @"C:\Users\...\samples";
                Console.WriteLine("Enter directory name:");
                string newDirectory = Console.ReadLine();
                Console.WriteLine("Enter file name:");
                string fileName = Console.ReadLine();

                if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
                {
                    Console.WriteLine("Directory and File exist.");
                    Console.WriteLine("Press 'enter' to try again with a different name.");
                    Console.ReadLine();
                }
                else if (Directory.Exists($"{rootDirectory}\\{newDirectory}"))
                {
                    Console.WriteLine($"Directory {newDirectory} already exist at {rootDirectory}.");
                    Console.WriteLine("Press 'enter' to try again with a different name.");
                    Console.ReadLine();
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Congratulations! Directory and File are created.");
                    Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                    File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
                }
            }
        }
    }
}
