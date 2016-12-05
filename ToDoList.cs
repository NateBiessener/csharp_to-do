using System;
using System.Collections.Generic;

namespace CommandLineToDo
{
    //This class may just be a superfluous wrapper for a List of ListItems, 
    //but it's my first stab at C# and I want the practice.
    //If nothing else, it might make Main a little more human readable. 
    class ToDoList
    {
        protected List<ListItem> ActualList{ get; private set; }

        public ToDoList()
        {
            ActualList = new List<ListItem> {};
        }

        public ToDoList(List<ListItem> items)
        {
            ActualList = items;
        }

        public void DisplayList()
        {
            for (int i = 0; i < ActualList.Count; i++)
            {
                Console.WriteLine((i+1) + ". " + ActualList[i].Task + " " + ActualList[i].Priority);
            }
        }

        public void Add(string task)
        {
            ListItem NewItem = new ListItem(task);
            ActualList.Add(NewItem);
        }

        public void Add(string task, int priority)
        {
            ListItem NewItem = new ListItem(task, priority);
            ActualList.Add(NewItem);
        }

        public void ChangeTask(int itemIndex, string newTask)
        {
            ActualList[itemIndex].SetTask(newTask);
        }

        public void ChangePriority(int itemIndex, int newPriority)
        {
            ActualList[itemIndex].SetPriority(newPriority);
        }

        public void DeleteItem(int itemIndex)
        {
            ActualList.RemoveAt(itemIndex);
        }

        public bool ContainsIndex(int index)
        {
            try
            {
                var test = ActualList[index];
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Sort(){
            ActualList.Sort();
        }

    }
    
}