namespace LinkedList;

public class Node
{
    int _data;

    Node _next;

    public Node(int data) => _data = data;

    public int Data { get => _data; set => _data = value; }
    public Node Next { get => _next; set => _next = value; }

    public override string ToString()
    {
        return $"Node[Data] = {_data} ::: NextNode[Data] = {(_next is not null ? _next.Data : null)}";
    }

}
