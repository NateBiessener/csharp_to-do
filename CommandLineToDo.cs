using System.Collections.Generic;

namespace CommandLineToDo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ToDoList HelloWorldList = new ToDoList();
            HelloWorldList.Add("First Task");
            HelloWorldList.Add("Second Task", 5);
            HelloWorldList.DisplayList();
        }
    }
}
