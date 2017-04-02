using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TraineeTasks
{
    class MyLinkedList<T>
    {

        private Node<T> Head;
        private Node<T> Tail;
        public int Count;        


        public MyLinkedList()
        {
            Head = new Node<T>();
            Tail = Head;
            Count = 0;
        }

        public Node<T> AddFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            Head.Previous = node;


            node.Next = Head.Value != null ? Head : null;

            if (Tail.Value == null)
                Tail = node;
            
            Head = node;
            Count++;
            return Head;
        }

        public Node<T> AddLast(T data)
        {
            Node<T> node = new Node<T>(data);

            node.Previous = Tail.Value != null ? Tail : null;  

            Tail.Next = node;
            Tail = node;

            if (Head.Value == null)
                Head = node;

            Count++;
            return Tail;
        }

        public void PrintAllValues()
        {
            StringBuilder output = new StringBuilder();
            Node<T> nodeContainer = (Node<T>)Head.Clone();
            output.Append(string.Format("Your Linked List contans values:\n"));
            while (nodeContainer != null)
            {
                output.Append(string.Format("{0}", nodeContainer.Value));
                output.Append(" ");
                nodeContainer = nodeContainer.Next;
            }

            Console.WriteLine(output);
        }

        public void Reverse()
        {
            
            Node<T> container = Tail.Previous;
            Tail.Previous = null;
            Head = Tail;
            
            while(container != null)
            {
                Node<T> node = new Node<T>();
                node.Value = container.Value;
                node.Previous = Tail;
                node.Next = null;
                Tail.Next = node;
                Tail = node;


                container = container.Previous;
            }
        }



    }

    public class Node<T> : ICloneable
    {
        public Node<T> Next;
        public object Value;
        public Node<T> Previous;

        public Node() { }

        public Node(T Value)
        {
            this.Value = Value;
        }

        public object Clone()
        {
            Node<T> newNode = new Node<T>() { Next = this.Next, Value = this.Value, Previous = this.Previous};
            return newNode;
        }
    }
}
