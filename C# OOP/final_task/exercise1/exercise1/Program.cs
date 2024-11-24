using System;
using System.Collections.Generic;

public class GenericList<T>
{
    private List<T> _list = new List<T>();

    public void Add(T element)
    {
        _list.Add(element);
    }

    public T GetFirstElement()
    {
        if (_list.Count > 0)
        {
            return _list[0];
        }
        throw new InvalidOperationException("The list is empty.");
    }

    public void DisplayFirstElement()
    {
        Console.WriteLine("First Element: " + GetFirstElement());   
    }
}

class Program
{
    static void Main()
    {
        GenericList<int> intList = new GenericList<int>();
        intList.Add(10);
        intList.Add(20);
        intList.Add(30);
        intList.DisplayFirstElement();

        GenericList<string> stringList = new GenericList<string>();
        stringList.Add("Hello");
        stringList.Add("World");
        stringList.DisplayFirstElement();
    }
}