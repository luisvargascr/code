namespace DataStructures
{
    public class SinglyLinkedList
    {
        private Node _head;

        public void AddToBeginning(Node node)
        {
            if (_head == null)
                _head = node;
            else
            {
                node.Next = _head;
                _head = node;
            }
        }
        public void AddToEnd (Node node)
        {
            if (_head == null)
            {
                _head = node;
            }
            else
            {
                node.Next = null;
                Node last = _head;

                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = node;
            }
        }
        public void DeleteNode(Node node)
        {
            if (_head == null)
                return;

            Node first = _head;

            if (first.Data == node.Data)
            {
                _head = first.Next;
                return;
            }
            while (first.Next != null)
            {
                if (first.Data != node.Data)
                {
                    first = first.Next;
                }
                else
                {
                    first = first.Next;
                    // first.Next = first.Next.Next;
                }
            }
        }

        public void DeleteNode2(int position)
        {
            // If linked list is empty
            if (_head == null)
                return;

            // Store head node
            Node temp = _head;

            // If head needs to be removed
            if (position == 0)
            {
                _head = temp.Next;   // Change head
                return;
            }

            // Find previous node of the node to be deleted
            for (int i = 0; temp != null && i < position - 1; i++)
                temp = temp.Next;

            // If position is more than number of ndoes
            if (temp == null || temp.Next == null)
                return;

            // Node temp->next is the node to be deleted
            // Store pointer to the next of node to be deleted
            Node next = temp.Next.Next;

            temp.Next = next;  // Unlink the deleted node from list
        }
    }
}
