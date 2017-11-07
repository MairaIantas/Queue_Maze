using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Queue_Maze;

namespace Queue_Maze_Test
{
    [TestClass]
    public class PointTest
    {
        /// <summary>
        /// Method to test string method
        /// </summary>
        [TestMethod]
        public void testToString()
        {
            Point point = new Point(0, 0);
            Assert.AreEqual(point.ToString(), "[0,0]");
        }

        /// <summary>
        /// Method to test string method
        /// </summary>
        [TestMethod]
        public void testToStringSecondConstructor()
        {
            Point point = new Point(1,1,0,0);
            Assert.AreEqual(point.ToString(), "[1,1]");
        }
    }

}
