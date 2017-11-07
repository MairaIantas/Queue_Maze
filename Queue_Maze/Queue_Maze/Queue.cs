using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Maze
{
    /// <summary>
    /// Represents a first-in, first-out collection of objects.
    /// </summary>
    /// <typeparam name="T">Specifies the type of elements in the stack</typeparam>
    public class Queue<T>
    {
        #region Properties  

        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Size { get; set; }
        private const string MESSAGE = "No such element.";

        #endregion

        /// <summary>
        /// constructor
        /// </summary>
        public Queue() { }

        /// <summary>
        /// Add a new node to the Queue at the tail
        /// </summary>
        /// <param name="element"></param>
        public void Enqueue(T element)
        {
            Node<T> newNode = new Node<T>(element, Head);

            if (Size == 0)
            {
                Head = newNode;
            }
            else
            {
                Tail.Next = newNode;
            }

            Tail = newNode;

            Size++;
        }

        /// <summary>
        /// Return the first data item on the queue
        /// </summary>
        /// <returns></returns>
        public T Front()
        {
            if (Size == 0)
            {
                throw new ApplicationException(MESSAGE);
            }

            return Head.Element;
        }

        /// <summary>
        /// Remove the node at the head of the Queue and return the data it contains
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            if (Size == 0)
            {
                throw new ApplicationException(MESSAGE);
            }

            Node<T> HeadsCopy = Head;

            if (Size == 1)
            {
                Tail = Head = null;
            }
            else
            {
                Head = Head.Next;
            }

            Size--;
            return HeadsCopy.Element;
        }

        /// <summary>
        /// Returns the Queue size
        /// </summary>
        /// <returns></returns>
        public int GetSize() { return this.Size; }

        /// <summary>
        /// Returns a true if the queue is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() { return GetSize() <= 0; }
    }
}
