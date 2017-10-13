using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackMaze
{
    /// <summary>
    /// Contains information added to the stack (a point in the maze in this assignment)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public T Element { get; set; }
        public Node<T> Previous { get; set; }

        public Node(T element, Node<T> previous)
        {
            Element = element;
            Previous = previous;
        }
    }
}
