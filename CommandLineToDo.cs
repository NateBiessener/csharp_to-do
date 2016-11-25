using System.Collections.Generic;

namespace CommandLineToDo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListItem firstItem = new ListItem("First task");
            ListItem secondItem = new ListItem("Second task");
            List<ListItem> TestToDos = new List<ListItem> {firstItem, secondItem};
            ToDoList HelloWorldList = new ToDoList(TestToDos);
            HelloWorldList.DisplayList();
        }
    }
}
