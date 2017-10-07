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
            var Node1 = new Node();
            Node1.Data = 1;
            var Node2 = new Node();
            Node2.Data = 2;
            var Node3 = new Node();
            Node3.Data = 3;

            LinkedList.AddToBeginning(Node1);
            LinkedList.AddToBeginning(Node2);
            LinkedList.AddToBeginning(Node3);

            LinkedList.DeleteNode(Node2);

            //LinkedList.AddToEnd(Node1);
            //LinkedList.AddToEnd(Node2);
            //LinkedList.AddToEnd(Node3);
        }
    }
}
