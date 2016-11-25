
namespace CommandLineToDo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ToDoList HelloWorldList = new ToDoList();
            HelloWorldList.Add("First Task");
            HelloWorldList.Add("Second Task", 1);
            HelloWorldList.DisplayList();
            HelloWorldList.Sort();
            HelloWorldList.DisplayList();
        }
    }
}
