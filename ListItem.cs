namespace CommandLineToDo
{
    class ListItem
    {
        public string Task {get; private set;}
        public ListItem(string task)
        {
            Task = task;
        }
    }
}