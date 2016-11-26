namespace CommandLineToDo
{
    class ListItem
    {
        public string Task {get; private set;}

        public int Priority {get; private set;}
       //set default priority if only a task description is provided
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

        public void SetTask(string task)
        {
            Task = task;
        }

        public void SetPriority(int priority)
        {
            Priority = priority;
        }
    }
}