using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackMaze;

namespace StackMazeTest
{
    [TestClass]
    public class NodeTest
    {
        /// <summary>
        /// Method to test if the constructor successful 
        /// </summary>
        [TestMethod]
        public void testNodeConstructor()
        {
            Stack<Point> myStack = new Stack<Point>();
            Point element = new Point(0, 0);
            Node<Point> prev = null;

            Assert.IsTrue(new Node<Point>(element, prev).Element == element);
            Assert.IsTrue(new Node<Point>(element, prev).Previous == null);
        }
    }
}
