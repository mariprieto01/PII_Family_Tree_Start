using System;
using Library;

namespace Library
{
    public class LongestNameVisitor : IVisitor
    {
        private string longestName = string.Empty;

        public void Visit(Node node)
        {
            if (node.Person != null)
            {
                string currentName = node.Person.Name;
                if (currentName.Length > longestName.Length)
                {
                    longestName = currentName;
                }
            }

            foreach (var child in node.Children)
            {
                child.Accept(this);
            }
        }

        public string GetLongestName()
        {
            return longestName;
        }
    }
}
