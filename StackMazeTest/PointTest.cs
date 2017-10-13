using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackMaze;

namespace StackMazeTest
{
    [TestClass]
    public class PointTest
    {
        /// <summary>
        /// Method to test point constructor
        /// </summary>
        [TestMethod]
        public void testPointConstructor()
        {
            Point point = new Point(0, 0);
            Assert.IsNotNull(point);
        }

        /// <summary>
        /// Method to test string method
        /// </summary>
        [TestMethod]
        public void testToString()
        {
            Point point = new Point(0, 0);
            Assert.AreEqual(point.ToString(), "[0,0]");
        }
    }
}
