using System;
using Library;

namespace Library
{
    public class AgeSumVisitor : IVisitor
    {
        public int AgeSum { get; private set; }

        public AgeSumVisitor()
        {
            AgeSum = 0;
        }

        public void Visit(Node node)
        {
            if (node.Person != null)
            {
                AgeSum += node.Person.Age;
            }

            foreach (var child in node.Children)
            {
                child.Accept(this);
            }
        }

        public int GetAgeSum()
        {
            return AgeSum;
        }
    }
}
