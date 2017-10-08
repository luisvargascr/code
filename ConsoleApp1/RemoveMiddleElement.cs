using DataStructures;

namespace ChapterTwo
{
    public class RemoveMiddleElement
    {
        public SinglyLinkedList LinkedList { get; set; }
        public RemoveMiddleElement()
        {
            var SingleNode1 = new SingleNode
            {
                Data = 1
            };
            var SingleNode2 = new SingleNode()
            {
                Data = 2
            };
            var SingleNode3 = new SingleNode()
            {
                Data = 3
            };
            var SingleNode4 = new SingleNode()
            {
                Data = 4
            };
            var SingleNode5 = new SingleNode()
            {
                Data = 5
            };

            LinkedList = new SinglyLinkedList();
            LinkedList.AddToEnd(SingleNode1);
            LinkedList.AddToEnd(SingleNode2);
            LinkedList.AddToEnd(SingleNode3);
            LinkedList.AddToEnd(SingleNode4);
            LinkedList.AddToEnd(SingleNode5);
        }
        /// <summary>
        /// This is my implementation. I assume that when they say "remove from middle", the
        /// size of the linked list is odd and we want to remove exactly the node in the middle.
        /// </summary>
        public void DeleteNodeInMiddle()
        {
            if (LinkedList.Head == null)
                return;

            SingleNode prev = LinkedList.Head;
            SingleNode Current = prev.Next;

            int Length = 1; // Starts off with 1 because we are counting the head value.
            int index = 0;

            while (prev.Next != null)
            {
                Length += 1;
                prev = prev.Next;
            }
            prev = LinkedList.Head;

            while (prev.Next != null)
            {
                if (index >= (Length / 2) - 1 && index < (Length/2))
                {
                    SingleNode NodeToDel = Current;
                    prev.Next = Current.Next;
                    Current.Next = null;
                    return;
                }
                prev = prev.Next;
                index++;
                Current = prev.Next;
            }
        }
    }
}
