using ChapterTwo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var LinkedList = new SinglyLinkedList();
            var Node1 = new SingleNode
            {
                Data = 1
            };
            var Node2 = new SingleNode
            {
                Data = 2
            };
            var Node3 = new SingleNode
            {
                Data = 3
            };

            LinkedList.AddToBeginning(Node1);
            LinkedList.AddToBeginning(Node2);
            LinkedList.AddToBeginning(Node3);

            LinkedList.DeleteNode(Node2);

            var Node4 = new DoublyNode
            {
                Data = 4
            };
            var Node5 = new DoublyNode
            {
                Data = 5
            };
            var Node6 = new DoublyNode
            {
                Data = 6
            };

            //var DoublyLinkedList = new DoublyLinkedList();
            //DoublyLinkedList.AddToTail(Node4);
            //DoublyLinkedList.AddToTail(Node5);
            //DoublyLinkedList.AddToTail(Node6);

            var CircularLinkedList = new CircularLinkedList();
            CircularLinkedList.AddToHead(Node4);
            CircularLinkedList.AddToHead(Node5);
            CircularLinkedList.AddToHead(Node6);
            CircularLinkedList.DeleteNote(Node5);

            var remove = new RemoveDuplicates();
            remove.RemoveDuplicateNoHashNorDic();
        }
    }
}
