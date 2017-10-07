namespace DataStructures
{
    public class CircularLinkedList
    {
        private DoublyNode _head;
        private DoublyNode _tail;

        public void AddLast (DoublyNode node)
        {
            if (_head == null)
            {
                _head = node;
                _tail = _head;
                _head.Next = _tail;
                _head.Prev = _tail;
            }
            else
            {
                _tail.Next = node;
                node.Next = _head;
                node.Prev = _tail;
                _tail = node;
                _head.Prev = _tail;
            }
        }
        public void AddFirst (DoublyNode node)
        {
            if (_head == null)
            {
                _head = node;
                _tail = _head;
                _head.Next = _tail;
                _head.Prev = _tail;
            }
            else
            {
                _head.Prev = node;
                node.Prev = _tail;
                node.Next = _head;
                _tail.Next = node;
                _head = node;
            }
        }
        public DoublyNode Find (DoublyNode node)
        {
            DoublyNode result = _head;

            while (result.Next != _head)
            {
                if (result.Data == node.Data)
                    return result;

                result = result.Next;
            }
            result = null;
            return result;
        }
        public bool DeleteNote(DoublyNode node)
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
