using System;
namespace CommandLineToDo
{
    class List
    {
        protected ListItem[] ToDoList{ get; private set; }

        public List(ListItem[] items)
        {
            ToDoList = items;
        }

        public void DisplayList()
        {
            foreach (ListItem item in ToDoList)
            {
                Console.WriteLine(item.Task);
            }
        }
    }
    
}