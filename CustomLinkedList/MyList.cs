namespace CustomLinkedList
{
    public class MyList
    {
        private bool _isHead = false;

        public Node Head { get; private set; }
        public Node Tail { get; private set; }
        public int Size { get; private set; }

        public void Add(Node node)
        {
            if (!_isHead)
            {
                Head = node;
                _isHead = true;
                Size = Size += 1;
            }
            else
            {
                if (Tail != null)
                {
                    Tail.Next = node;
                    Tail = node;
                }
                else
                {
                    Head.Next = node;
                    Tail = node;
                }

                Size = Size += 1;
            }
        }

        public string PrintChain(Node rootNode) {
            int i = 0;
            string printed = "values:";
            Node acc = rootNode;

            while (i < Size)
            {
                printed = printed + " -> " + acc.Value;

                if (acc.Next != null)
                {
                    acc = acc.Next;
                }
                else
                {
                    break;
                }

                i++;
            }

            return printed;
        }

        public void Remove(int index)
        {
            int i = 0;
            Node buffer = Head.Next ?? null;
            Node prevBuffer = Head;

            while (i < Size) {
                if (buffer != null)
                {
                    if (buffer.Index == index)
                    {
                        if (buffer.Next != null)
                        {
                            prevBuffer.Next = buffer.Next;
                            break;
                        } 
                        else
                        {
                            buffer = prevBuffer;
                            buffer.Next = null;
                            Tail = buffer;
                            break;
                        }
                    }
                    else
                    {
                        prevBuffer = buffer;
                        buffer = buffer.Next;
                    }
                }
                i++;
            }
        }

    }
}
