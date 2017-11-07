using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Maze
{
    /// <summary>
    /// Contains information added to the que Queue (a point in the maze in this assignment)
    /// </summary>
    /// <typeparam name="T">Specifies the type of elements in the stack</typeparam>
    public class Node<T>
    {
        #region Properties

        public T Element { get; set; }
        public Node<T> Next { get; set; }

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="element"></param>
        /// <param name="next"></param>
        public Node(T element, Node<T> next)
        {
            Element = element;
            Next = next;
        }

    }
}
