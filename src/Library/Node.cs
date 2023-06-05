using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private Person person;
        private List<Node> children = new List<Node>();

        public Person Person
        {
            get { return person; }
            set { person = value; }
        }
        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Person person)
        {
            this.Person = person;
        }
        public void AddChildren(Node n)
        {
            this.children.Add(n);
        } 
    }
}
