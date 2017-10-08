using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterTwo
{
    public class FindNElement
    {
        public SinglyLinkedList LinkedList { get; set; }
        public FindNElement()
        {
            var SingleNode1 = new SingleNode
            {
                Data = 7
            };
            var SingleNode2 = new SingleNode()
            {
                Data = 5
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
                Data = 9
            };
            var SingleNode6 = new SingleNode()
            {
                Data = 1
            };

            LinkedList = new SinglyLinkedList();
            LinkedList.AddToEnd(SingleNode1);
            LinkedList.AddToEnd(SingleNode2);
            LinkedList.AddToEnd(SingleNode3);
            LinkedList.AddToEnd(SingleNode4);
            LinkedList.AddToEnd(SingleNode5);
            LinkedList.AddToEnd(SingleNode6);
        }
        /// <summary>
        /// Find the Nth Element to the last element. This is my implementation...
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public SingleNode FindNToEnd (SingleNode node)
        {
            if (LinkedList.Head == null)
                return null;

            SingleNode NodeN = null;
            SingleNode tmp = LinkedList.Head;
            bool foundN = false;

            while (tmp.Next != null)
            {
                if (tmp.Data == node.Data)
                    foundN = true;

                if (foundN)
                {
                    SingleNode Ntmp = tmp;
                    Ntmp.Next = tmp.Next;
                    if (NodeN == null)
                    {
                        NodeN = Ntmp;
                        return NodeN;
                    }
                }
                tmp = tmp.Next;
            }
            return NodeN;
        }
    }
}
