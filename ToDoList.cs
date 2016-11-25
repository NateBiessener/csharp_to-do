using System;
namespace CommandLineToDo
{
    class ToDoList
    {
        protected ListItem[] ActualList{ get; private set; }

        public ToDoList(ListItem[] items)
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