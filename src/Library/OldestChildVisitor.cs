using System;
using Library;

namespace Library
{
    public class OldestChildVisitor : IVisitor
    {
        private int oldestAge;
        private Node oldestChild;

        public OldestChildVisitor()
        {
            oldestAge = 0;
            oldestChild = null;
        }

        public void Visit(Node node)
        {
            if (node.Person != null && node.Person.Age > oldestAge)
            {
                oldestAge = node.Person.Age;
                oldestChild = node;
            }

            foreach (var child in node.Children)
            {
                child.Accept(this);
            }
        }

        public int GetOldestAge()
        {
            return oldestAge;
        }

        public Node GetOldestChild()
        {
            return oldestChild;
        }
    }
}
