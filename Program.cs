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

    public void Append(int data)
    {
        Node newNode = new Node(data);

        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
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

public class Queue
{
    private LinkedList linkedList;

    public Queue()
    {
        linkedList = new LinkedList();
    }

    public void Enqueue(int data)
    {
        linkedList.Append(data);
    }

    public void DisplayQueue()
    {
        linkedList.DisplayList();
    }
}

public class Program
{
    public static void Main()
    {
        Queue queue = new Queue();
        queue.Enqueue(56);
        queue.Enqueue(30);
        queue.Enqueue(70);

        Console.WriteLine("Queue Elements:");
        queue.DisplayQueue();
    }
}