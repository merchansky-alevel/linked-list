using System;

namespace CustomLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node("value 1", 0);
            Node node2 = new Node("value 2", 1);
            Node node3 = new Node("value 3", 2);
            Node node4 = new Node("value 4", 3);
            Node node5 = new Node("value 5", 4);
            Node node6 = new Node("value 6", 5);
            Node node7 = new Node("value 7", 6);

            MyList nodes = new MyList();

            nodes.Add(node1);
            nodes.Add(node2);
            nodes.Add(node3);
            nodes.Add(node4);
            nodes.Add(node5);
            nodes.Add(node6);
            nodes.Add(node7);

            try
            {
                Node Head = nodes.Head;
                
                nodes.Remove(3);
                Console.WriteLine(nodes.PrintChain(Head));
                //Console.WriteLine(Head.Next.Next.Next.Next.Next.Value);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Element not found!");
            }            

            Console.Read();
        }
    }
}
