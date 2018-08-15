namespace CustomLinkedList
{
    public class Node
    {
        public Node Next { get; set; }
        public string Value { get; private set; }
        public int Index { get; private set; }

        public Node(string value, int index)
        {
            Value = value;
            Index = index;
        }
    }
}
