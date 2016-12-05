//no longer in use, refactored ListItem to inherit System.IComparable<T> interface and moved this code to the class.
//leaving the file in the repo for archival purposes

using System.Collections.Generic;

namespace CommandLineToDo
{
    //adapted from example in MSDN documentation for "List<T>.Sort Method (IComparer<T>)"
    class ListItemComparer: IComparer<ListItem>
    {
        public int Compare(ListItem x, ListItem y)
        {
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