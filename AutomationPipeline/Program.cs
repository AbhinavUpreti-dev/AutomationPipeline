using AutomationPipeline.Factory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Console Application!");
            try
            {
                while (true)
                {
                    Console.WriteLine("List of commands:");
                    Console.WriteLine("1. File Copy");
                    Console.WriteLine("2. File Delete");
                    Console.WriteLine("3. Query Folder Files");
                    Console.WriteLine("4. Create Folder");
                    Console.WriteLine("5. Download File");
                    Console.WriteLine("6. Wait");
                    Console.WriteLine("7. Conditional Count Rows File");
                    Console.WriteLine("8. Exit");

                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();
                    var choiceType = PipeLineFactory.GetChoice(choice);
                    if (choice != null)
                    {
                        choiceType?.Operation();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred {ex.Message}");
            }
           
        }
    }
}
