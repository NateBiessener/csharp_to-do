namespace CommandLineToDo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListItem firstItem = new ListItem("First task");
            ListItem secondItem = new ListItem("Second task");
            ListItem[] listArr = new ListItem[] {firstItem, secondItem};
            List HelloWorldList = new List(listArr);
            HelloWorldList.DisplayList();
        }
    }
}
