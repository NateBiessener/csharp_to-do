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

        //for use in Sort wrapper
        private ListItemComparer ListSorter = new ListItemComparer();
        public void Sort(){
            ActualList.Sort(ListSorter);
        }
    }
    
}