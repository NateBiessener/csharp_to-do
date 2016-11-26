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
                Console.WriteLine("\nYour list:");
                HelloWorldList.Sort();
                HelloWorldList.DisplayList();
                Console.WriteLine("\nType \"Add\" to add an item to your list, \"Edit\" to edit your list,\n\"Delete\" to remove an item from your list or \"Quit\" to exit this application.");
                string Input = Console.ReadLine();
                if (Input.ToLower() == "add")
                {
                    Console.WriteLine("\nEnter the task you would like to add to your list");
                    string Task = Console.ReadLine();
                    Console.WriteLine("\nEnter the priority you would like your task to have, with 1 being the highest priority and 5 being the lowest");
                    int Priority = Int32.Parse(Console.ReadLine());
                    HelloWorldList.Add(Task, Priority);
                    continue;
                }
                else if (Input.ToLower() == "quit")
                {
                    break;
                }
                else if (Input.ToLower() == "edit")
                {
                    Console.WriteLine("Enter the number of the item you would like to edit.");
                    //itemToEdit will be passed as the index within the list
                    int itemToEdit = Int32.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("Would you like to change the task or the priority?");
                    string option = Console.ReadLine();
                    //note: I'm not going to worry about input sanitizing and forgiveness for now
                    if (option.ToLower() == "task")
                    {
                        Console.WriteLine("Enter the new task description.");
                        string task = Console.ReadLine();
                        HelloWorldList.ChangeTask(itemToEdit, task);
                    }
                    if (option.ToLower() == "priority")
                    {
                        Console.WriteLine("Enter the new priority.");
                        int priority = Int32.Parse(Console.ReadLine());
                        HelloWorldList.ChangePriority(itemToEdit, priority);
                    }
                }
                else if (Input.ToLower() == "delete")
                {
                    Console.WriteLine("Enter the number of the item you would like to delete.");
                    int itemToDelete = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Are you sure you want to delete item #" + itemToDelete + "? Type \"Yes\" to confirm.");
                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        //subtract one to pass in actual index
                        HelloWorldList.DeleteItem(itemToDelete - 1);
                    }
                }
                else
                {
                    Console.WriteLine("\nThat was not a valid command");
                }
            }
        }
    }
}
