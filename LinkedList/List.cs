namespace LinkedList;

public class List
{
    Node _head;
    Node _tail;

    public List() => _head = _tail = null;

    public Node Head { get => _head; set => _head = value; }
    public Node Tail { get => _tail; set => _tail = value; }

    public void Push(int value) 
    {
        Node item = new Node(value);

        if (_head == null)
        {
            _head = _tail = item;
        }
        else
        {
            _tail.Next = item;
            _tail      = item;
        }
    } 

    public void Unshift(int value) 
    {
        Node item = new Node(value);

        if (_head == null)
        {
            _head = _tail = item;
        }
        else
        {
            item.Next  = _head;
            _head      = item;
        }
    }

    public void Remove(int value)
    {
        //List is empty
        if (_head == null)
        {
            System.Console.WriteLine("List is empty...");
            return;
        }

        //value is the first element in list
        if (_head.Data == value) 
        {
            _head = _head.Next;
            return;
        }

        Node prev = _head;
        Node curr = _head.Next;

        while (curr != null)
        {
            //value is found in middle of the list
            if (curr.Data == value)
            {
                prev = curr.Next;

                //value is the last element in list 
                if (prev.Next == null)
                {
                    _tail = prev;
                }
                return;
            }
            else
            {
                prev = prev.Next;
                curr = curr.Next;
            }
        }

        if (curr is null)
            System.Console.WriteLine("Item is NotFound....");
       
    }

    public bool Find(int value)
    {
        Node current = _head;
        int pos = 1;

        while (current is not null)
        {
            if (current.Data == value)
            {
                System.Console.WriteLine($"Item[{value}] is found in postion[{pos}]");
                return true;
            }
            else
            {
                pos++;
                current = current.Next;
            }
        }

        System.Console.WriteLine("Item is NotFound....");
        return false;
    }

    public void Display()
    {
        Node start = _head;

        if (start is null)
            System.Console.WriteLine("List is Empty");
        else
        {
            while (start is not null)
            {
                System.Console.WriteLine(start.Data);
                start = start.Next;
            }
        }
    }
}
