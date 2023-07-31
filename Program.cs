using System;

public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList
{
    public Node Head;

    public LinkedList()
    {
        Head = null;
    }

    public void Add(int data)
    {
        Node newNode = new Node(data);

        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head = newNode;
        }
    }

    public void DisplayList()
    {
        Node current = Head;
        while (current != null)
        {
            Console.Write(current.Data + "->");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

public class Stack
{
    private LinkedList linkedList;

    public Stack()
    {
        linkedList = new LinkedList();
    }

    public void Push(int data)
    {
        linkedList.Add(data);
    }

    public void DisplayStack()
    {
        linkedList.DisplayList();
    }
}

public class Program
{
    public static void Main()
    {
        Stack stack = new Stack();
        stack.Push(56);
        stack.Push(30);
        stack.Push(70);

        Console.WriteLine("Stack Elements:");
        stack.DisplayStack();
    }
}
