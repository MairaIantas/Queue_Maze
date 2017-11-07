using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Maze
{
    /// <summary>
    /// Describes a point in the maze (Numeric row and column coordinates)
    /// </summary>
    public class Point
    {
        #region Properties

        public int Row { get; set; }
        public int Column { get; set; }
        public int ParentRow { get; set; }
        public int ParentColumn { get; set; }

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public Point(int row, int column)
        {
            Row = row;
            Column = column;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="parentRow"></param>
        /// <param name="parentColumn"></param>
        public Point(int row, int column, int parentRow, int parentColumn)
        {
            Row = row;
            Column = column;
            ParentRow = parentRow;
            ParentColumn = ParentColumn;
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
