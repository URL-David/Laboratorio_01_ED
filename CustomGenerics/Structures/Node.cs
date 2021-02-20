using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomGenerics.Structures;

namespace CustomGenerics.Structures
{
    public class Node<T>
    {
        
        public Node(T t)
        {
            next = null;
            data = t;
        }

        private Node<T> next;
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        private Node<T> prev;
        public Node<T> Prev
        {
            get { return prev; }
            set { prev = value; }
        }


        private T data;

     
        public T Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
