using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackMaze
{
    /// <summary>
    /// Describes a point in the maze (Numeric row and column coordinates)
    /// </summary>
    public class Point
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Point(int row, int column)
        {
            Row = row;
            Column = column;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns></returns>
        override public string ToString()
        {
            return String.Format("[{0},{1}]", Row, Column);
        }
    }
}
