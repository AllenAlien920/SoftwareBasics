using System.Collections;

namespace Assignment4_1;

public class GenericList<T> : IEnumerable<T>
{
    private Node<T>? _head;
    private Node<T>? _tail;

    public void Add(T t)
    {
        Node<T> n = new Node<T>(t);
        if (_tail == null)
        {
            _head = _tail = n;
        }
        else
        {
            _tail.Next = n;
            _tail = n;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        var currentNode = _head;
        while (currentNode != null)
        {
            yield return currentNode.Data;
            currentNode = currentNode.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void ForEach(Action<T> action)
    {
        var currentNode = _head;
        while (currentNode != null)
        {
            action(currentNode.Data);
            currentNode = currentNode.Next;
        }
    }
}

public class Node<T>(T t)
{
    public Node<T>? Next { get; set; }
    public T Data { get; set; } = t;
}