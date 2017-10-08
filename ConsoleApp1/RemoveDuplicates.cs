﻿using DataStructures;
using System.Collections.Generic;

namespace ChapterTwo
{
    public class RemoveDuplicates
    {
        public SinglyLinkedList LinkedList { get; set; }

        public RemoveDuplicates()
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
                Data = 5
            };
            var SingleNode4 = new SingleNode()
            {
                Data = 8
            };
            var SingleNode5 = new SingleNode()
            {
                Data = 5
            };
            var SingleNode6 = new SingleNode()
            {
                Data = 3
            };

            LinkedList = new SinglyLinkedList();
            LinkedList.AddToEnd(SingleNode1);
            LinkedList.AddToEnd(SingleNode2);
            LinkedList.AddToEnd(SingleNode3);
            LinkedList.AddToEnd(SingleNode4);
            LinkedList.AddToEnd(SingleNode5);
            LinkedList.AddToEnd(SingleNode6);
        }
        public void RemoveDuplicateValues()
        {
            SingleNode tmp = LinkedList.Head;

            if (LinkedList.Head == null)
                return;

            var hits = new Dictionary<int, int>();
            while (tmp.Next !=null)
            {
                if (hits.Count == 0)
                {
                    hits.Add(tmp.Data, 1);
                }
                else
                {
                    if (hits.ContainsKey(tmp.Data))
                    {
                        hits[tmp.Data] += 1;
                        tmp = tmp.Next;
                        continue;
                    }
                    else
                    {
                        hits.Add(tmp.Data, 1);
                    }
                }
                tmp = tmp.Next;
            }
        }
    }
}