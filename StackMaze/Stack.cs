using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackMaze
{
    /// <summary>
    /// A new class that implements the Stack methods as discussed in the lectures.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T>
    {
        public Node<T> Head { get; set; }
        public int Size { get; set; }
        private const string MESSAGE = "No such element.";

        public Stack() { }

        /// <summary>
        /// Add a new node containing the element to the Stack at the head
        /// </summary>
        /// <param name="element"></param>
        public void Push(T element)
        {
            Head = new Node<T>(element, Head);
            Size++;
        }

        /// <summary>
        /// Return the first element item on the Stack. Throw an exception if empty.
        /// </summary>
        /// <returns></returns>
        public T Top()
        {
            if (Size == 0)
            {
                throw new ApplicationException(MESSAGE);
            }

            return Head.Element;
        }

        /// <summary>
        /// Remove the Node at the head of the Stack
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (Size == 0)
            {
                throw new ApplicationException(MESSAGE);
            }

            Node<T> current;

            current = Head;
            Head = Head.Previous;
            Size--;

            return current.Element;
        }

        /// <summary>
        /// Method that return the size
        /// </summary>
        /// <returns></returns>
        public int GetSize()
        {
            return Size;
        }

        /// <summary>
        /// Method that returns true if the size is less or equals to zero
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return GetSize() <= 0;
        }
    }
}
