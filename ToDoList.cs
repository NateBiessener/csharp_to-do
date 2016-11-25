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

        public void DisplayList()
        {
            foreach (ListItem item in ActualList)
            {
                Console.WriteLine(item.Task);
            }
        }
    }
    
}