using System;
using System.Collections.Generic;
using System.Linq;

namespace ChapterFour
{
    public class Graph
    {
        private Dictionary<int, Node> _nodeLookup;
        public Graph()
        {
            _nodeLookup = new Dictionary<int, Node>();
        }
        public Node GetNode(int id)
        {
            if (_nodeLookup.ContainsKey(id))
                return _nodeLookup[id];
            else
            {
                Node newNode = new Node(id);
                _nodeLookup.Add(id, newNode);
                return newNode;
            }
        }
        public void AddEdge(int source, int destination)
        {
            Node s = GetNode(source);
            Node d = GetNode(destination);
            s.adjacent.AddLast(d);
        }
        public bool HasPathDFS(int source, int destination)
        {
            Node s = GetNode(source);
            Node d = GetNode(destination);

            HashSet<int> visited = new HashSet<int>();

            return HasPathDFS(s, d, visited);
        }
        private bool HasPathDFS(Node source, Node destination, HashSet<int> visited)
        {
            Console.WriteLine(string.Format("Entering Node {0}.", source.id));

            if (visited.Contains(source.id))
            {
                Console.WriteLine(string.Format("Node {0} already visited!", source.id));
                return false;
            }
            visited.Add(source.id);
            if (source == destination)
            {
                Console.WriteLine(string.Format("--> Found! {0}, {1}", source.id, destination.id));
                return true;
            }
            foreach (Node child in source.adjacent)
            {
                if (HasPathDFS(child, destination, visited))
                {
                    
                    return true;
                }
            }
            return false;
        }
        public bool HasPathBFS(int source, int destination)
        {
            return HasPathBFS(GetNode(source), GetNode(destination));
        }
        private bool HasPathBFS(Node source, Node destination)
        {
            LinkedList<Node> nextToVisit = new LinkedList<Node>();
            HashSet<int> visited = new HashSet<int>();
            nextToVisit.AddFirst(source);

            while (nextToVisit.Count() > 0)
            {
                Node node = nextToVisit.FirstOrDefault();
                nextToVisit.RemoveFirst();

                if (node == destination)
                    return true;

                if (visited.Contains(node.id))
                    continue;

                visited.Add(node.id);

                foreach (Node child in node.adjacent)
                {
                    nextToVisit.AddLast(child);
                }
            }
            return false;
        }
    }
}
