using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;
        public Person Person { get; }

        private List<Node> children = new List<Node>();

        public int Number 
        {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number, Person person)
        {
            this.number = number;
            this.Person = person;
        }

        public void AddChildren(Node child)
        {
            children.Add(child);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
        
    }
}