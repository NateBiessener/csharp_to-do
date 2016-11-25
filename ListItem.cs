namespace CommandLineToDo
{
    class ListItem
    {
        public string Task {get; private set;}

        public int Priority {get; set;}
        public ListItem(string task)
        {
            Task = task;
            Priority = 3;
        }

        public ListItem(string task, int priority)
        {
            Task = task;
            Priority = priority;
        }
    }
}