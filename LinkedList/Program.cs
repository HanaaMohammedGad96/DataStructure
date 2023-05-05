using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node one = new Node(1);

            Node two = new Node(2);

            Node three = new Node(3);

            one.Next = two;

            Console.WriteLine(one);

            Console.WriteLine("========================");

            List lstOne = new List();

            lstOne.Push(1);
            lstOne.Push(2);
            lstOne.Push(3);
            lstOne.Push(4);
            //lstOne.Unshift(5555);


            lstOne.Display();

            // Console.WriteLine(lstOne.Find(12)); 
            Console.WriteLine("======");
            lstOne.Remove(2);
            lstOne.Display();
        }
    }
}
