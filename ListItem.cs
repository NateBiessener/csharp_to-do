namespace CommandLineToDo
{
    class ListItem  : System.IComparable<ListItem>
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

        public int CompareTo(ListItem y)
        {
            ListItem x = this;
            if (x == null)
            {
                if (y == null)
                {
                    // If x is null and y is null, they're
                    // equal. 
                    return 0;
                }
                else
                {
                    // If x is null and y is not null, y
                    // is greater. 
                    return -1;
                }
            }
            else
            {
                // If x is not null...
                //
                if (y == null)
                    // ...and y is null, x is greater.
                {
                    return 1;
                }
                else
                {
                    // ...and y is not null, compare the 
                    // priority of the two ListItems.

                    if (x.Priority > y.Priority)
                    {
                        //x is greater
                        return 1;
                    }
                    else if (y.Priority > x.Priority)
                    {
                        //y is greater
                        return -1;
                    }
                    else
                    {
                        // If the ListItems are of equal priority,
                        // sort them with string comparison of their tasks.
                        return x.Task.CompareTo(y.Task);
                    }
                }
            }
        }
    }
}