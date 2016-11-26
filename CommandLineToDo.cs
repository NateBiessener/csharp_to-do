using System;

namespace CommandLineToDo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ToDoList HelloWorldList = new ToDoList();
            Console.WriteLine("Welcome to your to-do list.");
            //for this loop, I'm making the continues explicit, even when they don't necessarily need to be
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
                    Console.WriteLine("\nEnter the priority (1 to 5) you would like your task to have, with 1 being the highest priority");
                    int Priority;
                    if (int.TryParse(Console.ReadLine(), out Priority))
                    {
                        HelloWorldList.Add(Task, Priority);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid priority.");
                        continue;
                    }
                }
                else if (Input.ToLower() == "quit")
                {
                    break;
                }
                else if (Input.ToLower() == "edit")
                {
                    Console.WriteLine("Enter the number of the item you would like to edit.");
                    int ItemToEdit;
                    if (int.TryParse(Console.ReadLine(), out ItemToEdit))
                    {
                        //itemToEdit will be passed as the index within the list
                        ItemToEdit--;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid number.");
                        continue;
                    }
                    Console.WriteLine("Would you like to change the task or the priority?");
                    string Option = Console.ReadLine();
                    if (Option.ToLower() == "task")
                    {
                        Console.WriteLine("Enter the new task description.");
                        string Task = Console.ReadLine();
                        HelloWorldList.ChangeTask(ItemToEdit, Task);
                        continue;
                    }
                    else if (Option.ToLower() == "priority")
                    {
                        Console.WriteLine("Enter the new priority.");
                        int Priority;
                        if (int.TryParse(Console.ReadLine(), out Priority))
                        {
                            HelloWorldList.ChangePriority(ItemToEdit, Priority);
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("That is not a valid priority.");
                            continue;
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid option.");
                        continue;
                    }
                }
                else if (Input.ToLower() == "delete")
                {
                    Console.WriteLine("Enter the number of the item you would like to delete.");
                    int ItemToDelete;
                    if (int.TryParse(Console.ReadLine(), out ItemToDelete))
                    {
                        Console.WriteLine("Are you sure you want to delete item #" + ItemToDelete + "? Type \"Yes\" to confirm.");
                        //subtract one to pass in actual index to DeleteItem call
                        ItemToDelete--;
                        if(!HelloWorldList.ContainsIndex(ItemToDelete))
                        {
                            Console.WriteLine("That is not an item in your list.");
                            continue;
                        }   
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid number.");
                        continue;
                    }
                    
                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        HelloWorldList.DeleteItem(ItemToDelete);
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("\nThat was not a valid command");
                    continue;
                }
            }
        }
    }
}
