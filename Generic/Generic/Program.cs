using System;
using System.Collections.Generic;
using System.Linq;

public class VTypeCol<T> where T : struct // Constraint for value types
{
    private List<T> col;

    public VTypeCol()
    {
        col = new List<T>();
    }

    public void AddItem(T item)
    {
        col.Add(item);
    }

    public T GetItem(int index)
    {
        if (index >= 0 && index < col.Count)
        {
            return col[index];
        }
        else
        {
            throw new IndexOutOfRangeException("Index is out of range");
        }
    }

    public List<T> DescendingOrderSorted()
    {
        List<T> sortCol = col.OrderByDescending(x => x).ToList();
        return sortCol;
    }
}

class Program
{
    static void Main(string[] args)
    {
        VTypeCol<int> Collect = new VTypeCol<int>();
        Collect.AddItem(2);
        Collect.AddItem(6);
        Collect.AddItem(4);

        Console.WriteLine("Item at index 1: " + Collect.GetItem(1));

        List<int> des = Collect.DescendingOrderSorted();
        Console.WriteLine("Des Sorted Collection:");
        foreach (int item in des)
        {
            Console.WriteLine(item);
        }
    }
}
