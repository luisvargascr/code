using System.Collections.Generic;

namespace ChapterFour
{
    public class Node
    {
        public int id { get; set; }
        public LinkedList<Node> adjacent { get; set; }

        public Node (int ID)
        {
            id = ID;
            adjacent = new LinkedList<Node>();
        }
    }
}
