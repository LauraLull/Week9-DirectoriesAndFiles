using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\samples\shoppingList";
            string fileName = @"\\myShoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add something to shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter what you need to buy:");
                    string userItem = Console.ReadLine();
                    myShoppingList.Add(userItem);
                }
                else if (userInput == 'n')
                {
                    loopActive = false;
                    Console.Clear();

                    Console.WriteLine("Your shopping list:");
                    foreach (string item in myShoppingList)
                    {
                        Console.WriteLine($"{item}");
                    }

                    File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);
                }
                else
                {
                    Console.WriteLine("Take care!");
                    break;
                }
            }
        }
    }
}
