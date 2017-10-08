namespace DataStructures
{
    public class DoublyLinkedList
    {
        private DoublyNode _tail;
        private DoublyNode _head;

        public void AddToHead(DoublyNode node)
        {
            if (_head != null)
            {
                _head.Prev = node;
            }

            _head = node;

            if (_tail == null)
            {
                _tail = node;
            }
        }
        public void AddToTail (DoublyNode node)
        {
            if (_tail != null)
            {
                _tail.Next = node;
            }

            _tail = node;

            if (_head == null)
            {
                _head = node;
            }
        }
        public bool DeleteNote (DoublyNode node)
        {
            if (_head == null)
                return true;

            DoublyNode Tmp = _head;

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
