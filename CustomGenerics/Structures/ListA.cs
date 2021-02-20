using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomGenerics.Structures;

namespace CustomGenerics.Structures
{
    public class ListA<T> :  IEnumerable<T>
    {
        public CustomGenerics.Structures.Node<T> Primero;
        public CustomGenerics.Structures.Node<T> Ultimo;
        public int count;

        public ListA()
        {
            Primero = null;
            Ultimo = null;
            count = 0;
        }

        public void Add(T value)
        {
           CustomGenerics.Structures.Node<T> NNode = new CustomGenerics.Structures.Node<T>(value)
           { Data = value, Next = null, Prev = null};
            Insert(NNode);
        }

        public T GDelete()
        {
            var value = Get();
            Delete();
            return value;
        }

        public Node<T> ObT(int PosicionJ)
        {
            Node<T> node = Primero;
            for (int i = 0; i < PosicionJ; i++)
                {
                node = node.Next;
            }
            return node;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var lCopy = this;
            var actual = lCopy.Primero;
            while (actual != null)
            {
                yield return actual.Data;
                actual = actual.Next;
            }
        }

        public void Insert(Node<T> NNode)
        {
            if (Primero == null)
            {
                Primero = NNode;
                Ultimo = NNode;
                NNode.Next = null;
                NNode.Prev = null;
            }
            else
            {
                NNode.Next = Primero;
                NNode.Prev = Ultimo;
                Primero = NNode;
                Ultimo.Next = Primero;
                (Primero.Next).Prev = Primero;
            }
            count++;



        }

       public void Delete()
        {
            if (this.count <= 1)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Ultimo = Ultimo.Prev;
                Ultimo.Next = Primero;
                count--;
            }
        }

        public T Get()
        {
            return Ultimo.Data;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
