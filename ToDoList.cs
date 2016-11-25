using System;
using System.Collections.Generic;

namespace CommandLineToDo
{
    class ToDoList
    {
        protected List<ListItem> ActualList{ get; private set; }

        public ToDoList(List<ListItem> items)
        {
            ActualList = items;
        }

        public ToDoList()
        {
            ActualList = new List<ListItem> {};
        }

        public void DisplayList()
        {
            foreach (ListItem item in ActualList)
            {
                Console.WriteLine(item.Task + " " + item.Priority);
            }
        }

        public List<ListItem> Add(string task)
        {
            ListItem NewItem = new ListItem(task);
            ActualList.Add(NewItem);
            return ActualList;
        }

        public List<ListItem> Add(string task, int priority)
        {
            ListItem NewItem = new ListItem(task, priority);
            ActualList.Add(NewItem);
            return ActualList;
        }
    }
    
}