using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Lucía", 80);
            Person person2 = new Person("Cinthya", 53);
            Person person3 = new Person("Willy", 55);
            Person person4 = new Person("Martín", 22);
            Person person5 = new Person("María Noel", 20);
            Person person6 = new Person("Bruno", 23);
            Person person7 = new Person("Juan Ignacio", 20);
            Person person8 = new Person("Isabella", 12);


            Node n1 = new Node(1, person1);
            Node n2 = new Node(2, person2);
            Node n3 = new Node(3, person3);
            Node n4 = new Node(4, person4);
            Node n5 = new Node(5, person5);
            Node n6 = new Node(6, person6);
            Node n7 = new Node(7, person7);
            Node n8 = new Node(8, person8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí
            AgeSumVisitor ageVisitor = new AgeSumVisitor();
            n1.Accept(ageVisitor);

            // obtener suma de edades
            int sumOfAges = ageVisitor.GetAgeSum();
            Console.WriteLine("Suma de edades: " + sumOfAges);

            // crear visitador de OldestChildVisitor
            OldestChildVisitor oldestChildVisitor = new OldestChildVisitor();

            // visitar arbol y determinar el hijo mas grande
            n2.Accept(oldestChildVisitor);

            // obtener numero del hijo más grande
            int oldestChild = oldestChildVisitor.GetOldestAge();
            Console.WriteLine($"El hijo más grande tiene {oldestChild} años.");

            // crear visitador de NombreMasLargo
            LongestNameVisitor longestNameVisitor = new LongestNameVisitor();

            // visitar el arbol y determinar el nombre más largo
            n3.Accept(longestNameVisitor);

            // obtener el nombre más largo
            string longestName = longestNameVisitor.GetLongestName();
            Console.WriteLine("El nombre más largo es: " + longestName);
        }
    }
}