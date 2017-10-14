using ChapterFour;
using ChapterOne;
using ChapterTwo;
using System;

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

            //var remove = new RemoveDuplicates();
            //remove.RemoveDuplicateNoHashNorDic();

            var NElement = new FindNElement();
            var Node = NElement.FindNToEnd(new SingleNode() { Data = 3 });

            var MiddleElement = new RemoveMiddleElement();
            MiddleElement.DeleteNodeInMiddle();

            string[] MyValues = { "Caroline", "Caroline", "Luis", "Carlos", "John", "Maria", "Caroline", "Carlos" };

            var hashPractice = new HashPractice(MyValues);
            hashPractice.ReturnSingleItems();
            // Console.ReadLine();


            var GraphNetwork = new Graph();
            GraphNetwork.AddEdge(0, 1);
            GraphNetwork.AddEdge(1, 2);
            GraphNetwork.AddEdge(2, 3);
            GraphNetwork.AddEdge(3, 4);
            GraphNetwork.AddEdge(4, 5);

            // GraphNetwork.AddEdge(5, 6);
            GraphNetwork.AddEdge(6, 7);
            GraphNetwork.AddEdge(7, 8);
            GraphNetwork.AddEdge(8, 9);
            GraphNetwork.AddEdge(5, 0);
            GraphNetwork.AddEdge(9, 4);

            Console.WriteLine (GraphNetwork.HasPathDFS(0, 9));
            Console.ReadKey();
        }
    }
}
