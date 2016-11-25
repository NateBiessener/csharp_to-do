using System;

namespace CommandLineToDo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ToDoList HelloWorldList = new ToDoList();
            Console.WriteLine("Welcome to your to-do list.");
            
            while (true)
            {
                HelloWorldList.Sort();
                HelloWorldList.DisplayList();
                Console.WriteLine("\nType \"Add\" to add an item to your list, \"Edit\" to edit your list, or \"Quit\" to exit this application.");
                string Input = Console.ReadLine();
                if (Input.ToLower() == "add")
                {
                    Console.WriteLine("Enter the task you would like to add to your list");
                    string Task = Console.ReadLine();
                    Console.WriteLine("Enter the priority you would like your task to have, with 1 being the highest priority and 5 being the lowest");
                    string Priority = Console.ReadLine();
                    int ConvertedPriority = Int32.Parse(Priority);
                    HelloWorldList.Add(Task, ConvertedPriority);
                    continue;
                }
                if (Input.ToLower() == "quit")
                {
                    break;
                }
            }
        }
    }
}
