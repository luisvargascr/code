namespace DataStructures
{
    public class SinglyLinkedList
    {
        private SingleNode _head;

        public void AddToBeginning(SingleNode node)
        {
            if (_head == null)
                _head = node;
            else
            {
                node.Next = _head;
                _head = node;
            }
        }
        public void AddToEnd (SingleNode node)
        {
            if (_head == null)
            {
                _head = node;
            }
            else
            {
                node.Next = null;
                SingleNode last = _head;

                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = node;
            }
        }
        public bool DeleteNode (SingleNode node)
        {
            if (_head == null)
                return false;

            SingleNode Tmp = _head;

            if (Tmp.Data == node.Data)
            {
                Tmp = Tmp.Next;
                return true;
            }
            while (Tmp.Next != null)
            {
                if (Tmp.Next.Data == node.Data)
                {
                    Tmp.Next = Tmp.Next.Next;
                    return true;
                }
                Tmp = Tmp.Next;
            }
            return false;
        }
    }
}
